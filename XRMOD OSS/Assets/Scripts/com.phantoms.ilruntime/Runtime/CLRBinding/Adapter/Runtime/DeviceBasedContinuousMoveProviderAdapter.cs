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
    public class DeviceBasedContinuousMoveProviderAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(UnityEngine.XR.Interaction.Toolkit.DeviceBasedContinuousMoveProvider);
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

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.DeviceBasedContinuousMoveProvider, CrossBindingAdaptorType
        {
            CrossBindingFunctionInfo<UnityEngine.Vector2> mReadInput_0 = new CrossBindingFunctionInfo<UnityEngine.Vector2>("ReadInput");
            CrossBindingFunctionInfo<UnityEngine.Vector2, UnityEngine.Vector3> mComputeDesiredMove_1 = new CrossBindingFunctionInfo<UnityEngine.Vector2, UnityEngine.Vector3>("ComputeDesiredMove");
            CrossBindingMethodInfo<UnityEngine.Vector3> mMoveRig_2 = new CrossBindingMethodInfo<UnityEngine.Vector3>("MoveRig");
            CrossBindingMethodInfo mAwake_3 = new CrossBindingMethodInfo("Awake");

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

            protected override UnityEngine.Vector3 ComputeDesiredMove(UnityEngine.Vector2 input)
            {
                if (mComputeDesiredMove_1.CheckShouldInvokeBase(this.instance))
                    return base.ComputeDesiredMove(input);
                else
                    return mComputeDesiredMove_1.Invoke(this.instance, input);
            }

            protected override void MoveRig(UnityEngine.Vector3 translationInWorldSpace)
            {
                if (mMoveRig_2.CheckShouldInvokeBase(this.instance))
                    base.MoveRig(translationInWorldSpace);
                else
                    mMoveRig_2.Invoke(this.instance, translationInWorldSpace);
            }

            public void DoAwake()
            {
                Awake();
            }
            protected override void Awake()
            {
                if (mAwake_3.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_3.Invoke(this.instance);
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

