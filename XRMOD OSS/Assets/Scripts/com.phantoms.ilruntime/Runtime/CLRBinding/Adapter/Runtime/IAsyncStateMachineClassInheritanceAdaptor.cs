using System;
using System.Runtime.CompilerServices;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace ILRuntime.CLRBinding.Adapter
{
    public class AsyncStateMachineClassInheritanceAdaptor : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(IAsyncStateMachine);

        public override Type AdaptorType => typeof(AsyncStateMachineAdaptor);

        public override object CreateCLRInstance(AppDomain _appdomain, ILTypeInstance _instance)
        {
            return new AsyncStateMachineAdaptor(_appdomain, _instance);
        }

        public class AsyncStateMachineAdaptor : IAsyncStateMachine, CrossBindingAdaptorType
        {
            private readonly ILTypeInstance instance;
            private readonly AppDomain appDomain;

            private IMethod mMoveNext;
            private IMethod mSetStateMachine;
            private readonly object[] param1 = new object[1];

            public AsyncStateMachineAdaptor()
            {
            }

            public AsyncStateMachineAdaptor(AppDomain _appDomain, ILTypeInstance _instance)
            {
                this.appDomain = _appDomain;
                this.instance = _instance;
            }

            public ILTypeInstance ILInstance
            {
                get { return instance; }
            }

            public void MoveNext()
            {
                mMoveNext ??= instance.Type.GetMethod("MoveNext", 0);

                appDomain.Invoke(mMoveNext, instance, null);
            }

            public void SetStateMachine(IAsyncStateMachine _stateMachine)
            {
                mSetStateMachine ??= instance.Type.GetMethod("SetStateMachine");

                appDomain.Invoke(mSetStateMachine, instance, _stateMachine);
            }

            public override string ToString()
            {
                IMethod m = appDomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    return instance.ToString();
                }

                return instance.Type.FullName;
            }
        }
    }
}