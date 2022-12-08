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
    public class TeleportationProviderAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(UnityEngine.XR.Interaction.Toolkit.TeleportationProvider);
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

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.TeleportationProvider, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.TeleportRequest, System.Boolean> mQueueTeleportRequest_0 = new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.TeleportRequest, System.Boolean>("QueueTeleportRequest");
            CrossBindingMethodInfo mAwake_1 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mUpdate_2 = new CrossBindingMethodInfo("Update");

            bool isInvokingToString;
            ILTypeInstance instance;
            ILRuntime.Runtime.Enviorment.AppDomain appdomain;

            public Adapter()
            {

            }

            public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

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
            public override System.Boolean QueueTeleportRequest(UnityEngine.XR.Interaction.Toolkit.TeleportRequest teleportRequest)
            {
                if (mQueueTeleportRequest_0.CheckShouldInvokeBase(this.instance))
                    return base.QueueTeleportRequest(teleportRequest);
                else
                    return mQueueTeleportRequest_0.Invoke(this.instance, teleportRequest);
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

            protected override void Update()
            {
                if (mUpdate_2.CheckShouldInvokeBase(this.instance))
                    base.Update();
                else
                    mUpdate_2.Invoke(this.instance);
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

