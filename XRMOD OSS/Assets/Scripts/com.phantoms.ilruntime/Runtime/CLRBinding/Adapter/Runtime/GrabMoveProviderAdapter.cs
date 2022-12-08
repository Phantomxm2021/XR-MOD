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
    public class GrabMoveProviderAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get
            {
                return typeof(UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider);
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

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mAwake_0 = new CrossBindingMethodInfo("Awake");
            class ComputeDesiredMove_1Info : CrossBindingMethodInfo
            {
                static Type[] pTypes = new Type[] {typeof(System.Boolean).MakeByRefType(),typeof( UnityEngine.Vector3).MakeByRefType()};

                public ComputeDesiredMove_1Info()
                    : base("ComputeDesiredMove")
                {

                }

                protected override Type ReturnType { get { return typeof(UnityEngine.Vector3); } }

                protected override Type[] Parameters { get { return pTypes; } }
                public UnityEngine.Vector3 Invoke(ILTypeInstance instance, out System.Boolean attemptingMove)
                {
                    EnsureMethod(instance);
                    attemptingMove = default(System.Boolean);

                    if (method != null)
                    {
                        invoking = true;
                        UnityEngine.Vector3 __res = default(UnityEngine.Vector3);
                        try
                        {
                            using (var ctx = domain.BeginInvoke(method))
                            {
                            ctx.PushBool(attemptingMove);
                                ctx.PushObject(instance);
                                ctx.PushReference(0);
                                ctx.Invoke();
                            __res = ctx.ReadObject<UnityEngine.Vector3>();
                            attemptingMove = ctx.ReadBool(0);
                            }
                        }
                        finally
                        {
                            invoking = false;
                        }
                       return __res;
                    }
                    else
                        return default;
                }

                public override void Invoke(ILTypeInstance instance)
                {
                    throw new NotSupportedException();
                }
            }
            ComputeDesiredMove_1Info mComputeDesiredMove_1 = new ComputeDesiredMove_1Info();
            CrossBindingMethodInfo<UnityEngine.Vector3> mMoveRig_2 = new CrossBindingMethodInfo<UnityEngine.Vector3>("MoveRig");

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

            public void DoAwake()
            {
                Awake();
            }
            protected override void Awake()
            {
                if (mAwake_0.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_0.Invoke(this.instance);
            }

            protected override UnityEngine.Vector3 ComputeDesiredMove(out System.Boolean attemptingMove)
            {
                if (mComputeDesiredMove_1.CheckShouldInvokeBase(this.instance))
                    return base.ComputeDesiredMove(out attemptingMove);
                else
                    return mComputeDesiredMove_1.Invoke(this.instance, out attemptingMove);
            }

            protected override void MoveRig(UnityEngine.Vector3 translationInWorldSpace)
            {
                if (mMoveRig_2.CheckShouldInvokeBase(this.instance))
                    base.MoveRig(translationInWorldSpace);
                else
                    mMoveRig_2.Invoke(this.instance, translationInWorldSpace);
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

