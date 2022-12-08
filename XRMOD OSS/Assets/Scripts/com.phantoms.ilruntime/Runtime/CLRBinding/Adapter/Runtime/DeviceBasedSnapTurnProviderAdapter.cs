using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif

namespace ILRuntime.CLRBinding.Adapter
{   
    public class DeviceBasedSnapTurnProviderAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider);
            }
        }

        public override Type AdaptorType
        {
            get
            {
                return typeof(Adapter);
            }
        }

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<UnityEngine.Vector2> mReadInput_0 = new CrossBindingFunctionInfo<UnityEngine.Vector2>("ReadInput");
            CrossBindingMethodInfo mAwake_1 = new CrossBindingMethodInfo("Awake");
            CrossBindingFunctionInfo<UnityEngine.Vector2, System.Single> mGetTurnAmount_2 = new CrossBindingFunctionInfo<UnityEngine.Vector2, System.Single>("GetTurnAmount");

            bool isInvokingToString;
            ILTypeInstance instance;
            ILRuntime.Runtime.Enviorment.AppDomain appdomain;
            public ILTypeInstance ILInstance
            {
                get => instance;
                set => instance = value;
            }

            public ILRuntime.Runtime.Enviorment.AppDomain AppDomain
            {
                get => appdomain;
                set => appdomain = value;
            }
            public Adapter()
            {

            }

            public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }
            protected override UnityEngine.Vector2 ReadInput()
            {
                if (mReadInput_0.CheckShouldInvokeBase(this.instance))
                    return base.ReadInput();
                else
                    return mReadInput_0.Invoke(this.instance);
            }

            public void DoAwake()
            {
                Awake();
            }
            protected override void Awake()
            {
                if (mAwake_1.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_1.Invoke(this.instance);
            }

            protected override System.Single GetTurnAmount(UnityEngine.Vector2 input)
            {
                if (mGetTurnAmount_2.CheckShouldInvokeBase(this.instance))
                    return base.GetTurnAmount(input);
                else
                    return mGetTurnAmount_2.Invoke(this.instance, input);
            }

            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod("ToString", 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    if (!isInvokingToString)
                    {
                        isInvokingToString = true;
                        string res = instance.ToString();
                        isInvokingToString = false;
                        return res;
                    }
                    else
                        return instance.Type.FullName;
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}

