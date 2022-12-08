using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine.XR.Interaction.Toolkit;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif

namespace ILRuntime.CLRBinding.Adapter
{
    public class XRGrabInteractableAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable); }
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

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mAwake_0 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mOnDestroy_1 = new CrossBindingMethodInfo("OnDestroy");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>
                mProcessInteractable_2 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>(
                        "ProcessInteractable");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, UnityEngine.Transform>
                mGetAttachTransform_3 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor,
                        UnityEngine.Transform>("GetAttachTransform");

            CrossBindingMethodInfo mAddDefaultSingleGrabTransformer_4 =
                new CrossBindingMethodInfo("AddDefaultSingleGrabTransformer");

            CrossBindingMethodInfo mAddDefaultMultipleGrabTransformer_5 =
                new CrossBindingMethodInfo("AddDefaultMultipleGrabTransformer");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntering_6 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExiting_7 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExited_8 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExited");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, System.Boolean>
                mShouldMatchAttachPosition_9 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        System.Boolean>("ShouldMatchAttachPosition");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, System.Boolean>
                mShouldMatchAttachRotation_10 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        System.Boolean>("ShouldMatchAttachRotation");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, System.Boolean>
                mShouldSnapToColliderVolume_11 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        System.Boolean>("ShouldSnapToColliderVolume");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, UnityEngine.Transform>
                mInitializeDynamicAttachPose_12 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        UnityEngine.Transform>("InitializeDynamicAttachPose");

            CrossBindingMethodInfo mGrab_13 = new CrossBindingMethodInfo("Grab");
            CrossBindingMethodInfo mDrop_14 = new CrossBindingMethodInfo("Drop");
            CrossBindingMethodInfo mDetach_15 = new CrossBindingMethodInfo("Detach");

            CrossBindingMethodInfo<UnityEngine.Rigidbody> mSetupRigidbodyGrab_16 =
                new CrossBindingMethodInfo<UnityEngine.Rigidbody>("SetupRigidbodyGrab");

            CrossBindingMethodInfo<UnityEngine.Rigidbody> mSetupRigidbodyDrop_17 =
                new CrossBindingMethodInfo<UnityEngine.Rigidbody>("SetupRigidbodyDrop");

            CrossBindingMethodInfo mReset_18 = new CrossBindingMethodInfo("Reset");
            CrossBindingMethodInfo mOnEnable_19 = new CrossBindingMethodInfo("OnEnable");
            CrossBindingMethodInfo mOnDisable_20 = new CrossBindingMethodInfo("OnDisable");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, System.Single>
                mGetDistanceSqrToInteractor_21 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor, System.Single>(
                        "GetDistanceSqrToInteractor");

            CrossBindingFunctionInfo<UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>
                mGetDistance_22 =
                    new CrossBindingFunctionInfo<UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.DistanceInfo>(
                        "GetDistance");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor, System.Boolean>
                mIsHoverableBy_23 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor, System.Boolean>(
                        "IsHoverableBy");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor, System.Boolean>
                mIsSelectableBy_24 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor,
                        System.Boolean>("IsSelectableBy");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor> mAttachCustomReticle_25 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>("AttachCustomReticle");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor> mRemoveCustomReticle_26 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractor>("RemoveCustomReticle");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>
                mOnRegistered_27 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>(
                        "OnRegistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>
                mOnUnregistered_28 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>(
                        "OnUnregistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntering_29 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntered_30 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExiting_31 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExited_32 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExited");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntered_33 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs> mOnActivated_34 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>("OnActivated");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs> mOnDeactivated_35 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>("OnDeactivated");

            CrossBindingFunctionInfo<UnityEngine.Transform> mget_transform_36 =
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

            public void DoAwake()
            {
                Awake();
            }

            protected override void Awake()
            {
                if (instance == null) return;
                if (mAwake_0.CheckShouldInvokeBase(this.instance))
                    base.Awake();
                else
                    mAwake_0.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (instance == null) return;
                if (mOnDestroy_1.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_1.Invoke(this.instance);
            }

            public override void ProcessInteractable(
                UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase)
            {
                if (instance == null) return;
                if (mProcessInteractable_2.CheckShouldInvokeBase(this.instance))
                    base.ProcessInteractable(updatePhase);
                else
                    mProcessInteractable_2.Invoke(this.instance, updatePhase);
            }

            public override UnityEngine.Transform GetAttachTransform(
                UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return null;
                if (mGetAttachTransform_3.CheckShouldInvokeBase(this.instance))
                    return base.GetAttachTransform(interactor);
                else
                    return mGetAttachTransform_3.Invoke(this.instance, interactor);
            }

            protected override void AddDefaultSingleGrabTransformer()
            {
                if (instance == null) return;
                if (mAddDefaultSingleGrabTransformer_4.CheckShouldInvokeBase(this.instance))
                    base.AddDefaultSingleGrabTransformer();
                else
                    mAddDefaultSingleGrabTransformer_4.Invoke(this.instance);
            }

            protected override void AddDefaultMultipleGrabTransformer()
            {
                if (instance == null) return;
                if (mAddDefaultMultipleGrabTransformer_5.CheckShouldInvokeBase(this.instance))
                    base.AddDefaultMultipleGrabTransformer();
                else
                    mAddDefaultMultipleGrabTransformer_5.Invoke(this.instance);
            }

            protected override void OnSelectEntering(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntering_6.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntering(args);
                else
                    mOnSelectEntering_6.Invoke(this.instance, args);
            }

            protected override void OnSelectExiting(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExiting_7.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExiting(args);
                else
                    mOnSelectExiting_7.Invoke(this.instance, args);
            }

            protected override void OnSelectExited(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExited_8.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExited(args);
                else
                    mOnSelectExited_8.Invoke(this.instance, args);
            }

            protected override System.Boolean ShouldMatchAttachPosition(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor)
            {
                if (instance == null) return false;
                if (mShouldMatchAttachPosition_9.CheckShouldInvokeBase(this.instance))
                    return base.ShouldMatchAttachPosition(interactor);
                else
                    return mShouldMatchAttachPosition_9.Invoke(this.instance, interactor);
            }

            protected override System.Boolean ShouldMatchAttachRotation(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor)
            {
                if (instance == null) return false;
                if (mShouldMatchAttachRotation_10.CheckShouldInvokeBase(this.instance))
                    return base.ShouldMatchAttachRotation(interactor);
                else
                    return mShouldMatchAttachRotation_10.Invoke(this.instance, interactor);
            }

            protected override System.Boolean ShouldSnapToColliderVolume(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor)
            {
                if (instance == null) return false;
                if (mShouldSnapToColliderVolume_11.CheckShouldInvokeBase(this.instance))
                    return base.ShouldSnapToColliderVolume(interactor);
                else
                    return mShouldSnapToColliderVolume_11.Invoke(this.instance, interactor);
            }

            protected override void InitializeDynamicAttachPose(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor,
                UnityEngine.Transform dynamicAttachTransform)
            {
                if (instance == null) return;
                if (mInitializeDynamicAttachPose_12.CheckShouldInvokeBase(this.instance))
                    base.InitializeDynamicAttachPose(interactor, dynamicAttachTransform);
                else
                    mInitializeDynamicAttachPose_12.Invoke(this.instance, interactor, dynamicAttachTransform);
            }

            protected override void Grab()
            {
                if (instance == null) return;
                if (mGrab_13.CheckShouldInvokeBase(this.instance))
                    base.Grab();
                else
                    mGrab_13.Invoke(this.instance);
            }

            protected override void Drop()
            {
                if (instance == null) return;
                if (mDrop_14.CheckShouldInvokeBase(this.instance))
                    base.Drop();
                else
                    mDrop_14.Invoke(this.instance);
            }

            protected override void Detach()
            {
                if (instance == null) return;
                if (mDetach_15.CheckShouldInvokeBase(this.instance))
                    base.Detach();
                else
                    mDetach_15.Invoke(this.instance);
            }

            protected override void SetupRigidbodyGrab(UnityEngine.Rigidbody rigidbody)
            {
                if (instance == null) return;
                if (mSetupRigidbodyGrab_16.CheckShouldInvokeBase(this.instance))
                    base.SetupRigidbodyGrab(rigidbody);
                else
                    mSetupRigidbodyGrab_16.Invoke(this.instance, rigidbody);
            }

            protected override void SetupRigidbodyDrop(UnityEngine.Rigidbody rigidbody)
            {
                if (instance == null) return;
                if (mSetupRigidbodyDrop_17.CheckShouldInvokeBase(this.instance))
                    base.SetupRigidbodyDrop(rigidbody);
                else
                    mSetupRigidbodyDrop_17.Invoke(this.instance, rigidbody);
            }

            protected override void Reset()
            {
                if (instance == null) return;
                if (mReset_18.CheckShouldInvokeBase(this.instance))
                    base.Reset();
                else
                    mReset_18.Invoke(this.instance);
            }

            protected override void OnEnable()
            {
                if (instance == null) return;
                if (mOnEnable_19.CheckShouldInvokeBase(this.instance))
                    base.OnEnable();
                else
                    mOnEnable_19.Invoke(this.instance);
            }

            protected override void OnDisable()
            {
                if (instance == null) return;
                if (mOnDisable_20.CheckShouldInvokeBase(this.instance))
                    base.OnDisable();
                else
                    mOnDisable_20.Invoke(this.instance);
            }

            public override System.Single GetDistanceSqrToInteractor(
                UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return 0;
                if (mGetDistanceSqrToInteractor_21.CheckShouldInvokeBase(this.instance))
                    return base.GetDistanceSqrToInteractor(interactor);
                else
                    return mGetDistanceSqrToInteractor_21.Invoke(this.instance, interactor);
            }

            public override UnityEngine.XR.Interaction.Toolkit.DistanceInfo GetDistance(UnityEngine.Vector3 position)
            {
                if (instance == null) return new DistanceInfo();
                if (mGetDistance_22.CheckShouldInvokeBase(this.instance))
                    return base.GetDistance(position);
                else
                    return mGetDistance_22.Invoke(this.instance, position);
            }

            public override System.Boolean IsHoverableBy(
                UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractor interactor)
            {
                if (instance == null) return false;
                if (mIsHoverableBy_23.CheckShouldInvokeBase(this.instance))
                    return base.IsHoverableBy(interactor);
                else
                    return mIsHoverableBy_23.Invoke(this.instance, interactor);
            }

            public override System.Boolean IsSelectableBy(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractor interactor)
            {
                if (instance == null) return false;
                if (mIsSelectableBy_24.CheckShouldInvokeBase(this.instance))
                    return base.IsSelectableBy(interactor);
                else
                    return mIsSelectableBy_24.Invoke(this.instance, interactor);
            }

            public override void AttachCustomReticle(UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return;
                if (mAttachCustomReticle_25.CheckShouldInvokeBase(this.instance))
                    base.AttachCustomReticle(interactor);
                else
                    mAttachCustomReticle_25.Invoke(this.instance, interactor);
            }

            public override void RemoveCustomReticle(UnityEngine.XR.Interaction.Toolkit.IXRInteractor interactor)
            {
                if (instance == null) return;
                if (mRemoveCustomReticle_26.CheckShouldInvokeBase(this.instance))
                    base.RemoveCustomReticle(interactor);
                else
                    mRemoveCustomReticle_26.Invoke(this.instance, interactor);
            }

            protected override void OnRegistered(
                UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnRegistered_27.CheckShouldInvokeBase(this.instance))
                    base.OnRegistered(args);
                else
                    mOnRegistered_27.Invoke(this.instance, args);
            }

            protected override void OnUnregistered(
                UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnUnregistered_28.CheckShouldInvokeBase(this.instance))
                    base.OnUnregistered(args);
                else
                    mOnUnregistered_28.Invoke(this.instance, args);
            }

            protected override void OnHoverEntering(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntering_29.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntering(args);
                else
                    mOnHoverEntering_29.Invoke(this.instance, args);
            }

            protected override void OnHoverEntered(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntered_30.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntered(args);
                else
                    mOnHoverEntered_30.Invoke(this.instance, args);
            }

            protected override void OnHoverExiting(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExiting_31.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExiting(args);
                else
                    mOnHoverExiting_31.Invoke(this.instance, args);
            }

            protected override void OnHoverExited(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExited_32.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExited(args);
                else
                    mOnHoverExited_32.Invoke(this.instance, args);
            }

            protected override void OnSelectEntered(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntered_33.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntered(args);
                else
                    mOnSelectEntered_33.Invoke(this.instance, args);
            }

            protected override void OnActivated(UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs args)
            {
                if (instance == null) return;
                if (mOnActivated_34.CheckShouldInvokeBase(this.instance))
                    base.OnActivated(args);
                else
                    mOnActivated_34.Invoke(this.instance, args);
            }

            protected override void OnDeactivated(UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs args)
            {
                if (instance == null) return;
                if (mOnDeactivated_35.CheckShouldInvokeBase(this.instance))
                    base.OnDeactivated(args);
                else
                    mOnDeactivated_35.Invoke(this.instance, args);
            }

            public UnityEngine.Transform transform
            {
                get
                {
                    if (instance == null) return this.transform;
                    return mget_transform_36.Invoke(this.instance);
                }
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