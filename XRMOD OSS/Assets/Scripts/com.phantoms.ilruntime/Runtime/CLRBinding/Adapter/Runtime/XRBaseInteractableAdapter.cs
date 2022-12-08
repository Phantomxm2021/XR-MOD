using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif

namespace ILRuntime.CLRBinding.Adapter
{
    public class XRBaseInteractableAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable); }
        }

        public override Type AdaptorType
        {
            get { return typeof(Adapter); }
        }

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain,
            ILTypeInstance instance)
        {
            return new Adapter(appdomain, instance);
        }

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mReset_0 = new CrossBindingMethodInfo("Reset");
            CrossBindingMethodInfo mAwake_1 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mOnEnable_2 = new CrossBindingMethodInfo("OnEnable");
            CrossBindingMethodInfo mOnDisable_3 = new CrossBindingMethodInfo("OnDisable");
            CrossBindingMethodInfo mOnDestroy_4 = new CrossBindingMethodInfo("OnDestroy");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, UnityEngine.Transform>
                mGetAttachTransform_5 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor,
                        UnityEngine.Transform>("GetAttachTransform");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, System.Single>
                mGetDistanceSqrToInteractor_6 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, System.Single>(
                        "GetDistanceSqrToInteractor");

            CrossBindingFunctionInfo<UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>
                mGetDistance_7 =
                    new CrossBindingFunctionInfo<UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>(
                        "GetDistance");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor, System.Boolean>
                mIsHoverableBy_8 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor, System.Boolean>(
                        "IsHoverableBy");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, System.Boolean>
                mIsSelectableBy_9 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        System.Boolean>("IsSelectableBy");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor> mAttachCustomReticle_10 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>("AttachCustomReticle");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor> mRemoveCustomReticle_11 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>("RemoveCustomReticle");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>
                mProcessInteractable_12 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>(
                        "ProcessInteractable");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>
                mOnRegistered_13 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>(
                        "OnRegistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>
                mOnUnregistered_14 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>(
                        "OnUnregistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntering_15 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntered_16 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExiting_17 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExited_18 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExited");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntering_19 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntered_20 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExiting_21 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExited_22 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExited");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs> mOnActivated_23 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>("OnActivated");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs> mOnDeactivated_24 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>("OnDeactivated");

            CrossBindingFunctionInfo<UnityEngine.Transform> mget_transform_25 =
                new CrossBindingFunctionInfo<UnityEngine.Transform>("get_transform");

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

            protected override void Reset()
            {
                if (instance == null) return;
                if (mReset_0.CheckShouldInvokeBase(this.instance))
                    base.Reset();
                else
                    mReset_0.Invoke(this.instance);
            }

            public void DoAwake()
            {
                Awake();
            }

            protected override void Awake()
            {
                if (instance == null) return;
                if (mAwake_1.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_1.Invoke(this.instance);
            }

            protected override void OnEnable()
            {
                if (instance == null) return;
                if (mOnEnable_2.CheckShouldInvokeBase(this.instance))
                    base.OnEnable();
                else
                    mOnEnable_2.Invoke(this.instance);
            }

            protected override void OnDisable()
            {
                if (instance == null) return;
                if (mOnDisable_3.CheckShouldInvokeBase(this.instance))
                    base.OnDisable();
                else
                    mOnDisable_3.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (instance == null) return;
                if (mOnDestroy_4.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_4.Invoke(this.instance);
            }

            public override UnityEngine.Transform GetAttachTransform(
                UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return null;
                if (mGetAttachTransform_5.CheckShouldInvokeBase(this.instance))
                    return base.GetAttachTransform(interactor);
                else
                    return mGetAttachTransform_5.Invoke(this.instance, interactor);
            }

            public override System.Single GetDistanceSqrToInteractor(
                UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                
                if (instance == null) return 0;
                if (mGetDistanceSqrToInteractor_6.CheckShouldInvokeBase(this.instance))
                    return base.GetDistanceSqrToInteractor(interactor);
                else
                    return mGetDistanceSqrToInteractor_6.Invoke(this.instance, interactor);
            }

            public override UnityEngine.XR.Interaction.Toolkit.DistanceInfo GetDistance(UnityEngine.Vector3 position)
            {
                if (instance == null) return new DistanceInfo();
                if (mGetDistance_7.CheckShouldInvokeBase(this.instance))
                    return base.GetDistance(position);
                else
                    return mGetDistance_7.Invoke(this.instance, position);
            }

            public override System.Boolean IsHoverableBy(
                UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor interactor)
            {
                if (instance == null) return false;
                if (mIsHoverableBy_8.CheckShouldInvokeBase(this.instance))
                    return base.IsHoverableBy(interactor);
                else
                    return mIsHoverableBy_8.Invoke(this.instance, interactor);
            }

            public override System.Boolean IsSelectableBy(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor)
            {
                if (instance == null) return false;
                if (mIsSelectableBy_9.CheckShouldInvokeBase(this.instance))
                    return base.IsSelectableBy(interactor);
                else
                    return mIsSelectableBy_9.Invoke(this.instance, interactor);
            }

            public override void AttachCustomReticle(UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return;
                if (mAttachCustomReticle_10.CheckShouldInvokeBase(this.instance))
                    base.AttachCustomReticle(interactor);
                else
                    mAttachCustomReticle_10.Invoke(this.instance, interactor);
            }

            public override void RemoveCustomReticle(UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return;
                if (mRemoveCustomReticle_11.CheckShouldInvokeBase(this.instance))
                    base.RemoveCustomReticle(interactor);
                else
                    mRemoveCustomReticle_11.Invoke(this.instance, interactor);
            }

            public override void ProcessInteractable(
                UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase)
            {
                if (instance == null) return;
                if (mProcessInteractable_12.CheckShouldInvokeBase(this.instance))
                    base.ProcessInteractable(updatePhase);
                else
                    mProcessInteractable_12.Invoke(this.instance, updatePhase);
            }

            protected override void OnRegistered(
                UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnRegistered_13.CheckShouldInvokeBase(this.instance))
                    base.OnRegistered(args);
                else
                    mOnRegistered_13.Invoke(this.instance, args);
            }

            protected override void OnUnregistered(
                UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnUnregistered_14.CheckShouldInvokeBase(this.instance))
                    base.OnUnregistered(args);
                else
                    mOnUnregistered_14.Invoke(this.instance, args);
            }

            protected override void OnHoverEntering(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntering_15.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntering(args);
                else
                    mOnHoverEntering_15.Invoke(this.instance, args);
            }

            protected override void OnHoverEntered(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntered_16.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntered(args);
                else
                    mOnHoverEntered_16.Invoke(this.instance, args);
            }

            protected override void OnHoverExiting(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExiting_17.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExiting(args);
                else
                    mOnHoverExiting_17.Invoke(this.instance, args);
            }

            protected override void OnHoverExited(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExited_18.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExited(args);
                else
                    mOnHoverExited_18.Invoke(this.instance, args);
            }

            protected override void OnSelectEntering(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntering_19.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntering(args);
                else
                    mOnSelectEntering_19.Invoke(this.instance, args);
            }

            protected override void OnSelectEntered(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntered_20.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntered(args);
                else
                    mOnSelectEntered_20.Invoke(this.instance, args);
            }

            protected override void OnSelectExiting(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExiting_21.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExiting(args);
                else
                    mOnSelectExiting_21.Invoke(this.instance, args);
            }

            protected override void OnSelectExited(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExited_22.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExited(args);
                else
                    mOnSelectExited_22.Invoke(this.instance, args);
            }

            protected override void OnActivated(UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs args)
            {
                if (instance == null) return;
                if (mOnActivated_23.CheckShouldInvokeBase(this.instance))
                    base.OnActivated(args);
                else
                    mOnActivated_23.Invoke(this.instance, args);
            }

            protected override void OnDeactivated(UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs args)
            {
                if (instance == null) return;
                if (mOnDeactivated_24.CheckShouldInvokeBase(this.instance))
                    base.OnDeactivated(args);
                else
                    mOnDeactivated_24.Invoke(this.instance, args);
            }

            public UnityEngine.Transform transform
            {
                get { return mget_transform_25.Invoke(this.instance); }
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