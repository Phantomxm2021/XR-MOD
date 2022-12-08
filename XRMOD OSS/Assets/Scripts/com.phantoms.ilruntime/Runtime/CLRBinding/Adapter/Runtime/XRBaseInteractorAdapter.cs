using System;
using System.Collections.Generic;
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
    public class XRBaseInteractorAdapter : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor); }
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

        public class Adapter : UnityEngine.XR.Interaction.Toolkit.XRBaseInteractor, CrossBindingAdaptorType
        {
            CrossBindingMethodInfo mReset_0 = new CrossBindingMethodInfo("Reset");
            CrossBindingMethodInfo mAwake_1 = new CrossBindingMethodInfo("Awake");
            CrossBindingMethodInfo mOnEnable_2 = new CrossBindingMethodInfo("OnEnable");
            CrossBindingMethodInfo mOnDisable_3 = new CrossBindingMethodInfo("OnDisable");
            CrossBindingMethodInfo mStart_4 = new CrossBindingMethodInfo("Start");
            CrossBindingMethodInfo mOnDestroy_5 = new CrossBindingMethodInfo("OnDestroy");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractable, UnityEngine.Transform>
                mGetAttachTransform_6 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRInteractable,
                        UnityEngine.Transform>("GetAttachTransform");

            CrossBindingMethodInfo<System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable>>
                mGetValidTargets_7 =
                    new CrossBindingMethodInfo<System.Collections.Generic.List<
                        UnityEngine.XR.Interaction.Toolkit.IXRInteractable>>("GetValidTargets");

            CrossBindingFunctionInfo<System.Boolean> mget_isHoverActive_8 =
                new CrossBindingFunctionInfo<System.Boolean>("get_isHoverActive");

            CrossBindingFunctionInfo<System.Boolean> mget_isSelectActive_9 =
                new CrossBindingFunctionInfo<System.Boolean>("get_isSelectActive");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.TargetPriorityMode> mget_targetPriorityMode_10 =
                new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.TargetPriorityMode>(
                    "get_targetPriorityMode");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.TargetPriorityMode> mset_targetPriorityMode_11 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.TargetPriorityMode>(
                    "set_targetPriorityMode");

            CrossBindingFunctionInfo<
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>>
                mget_targetsForSelection_12 =
                    new CrossBindingFunctionInfo<System.Collections.Generic.List<
                        UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>>("get_targetsForSelection");

            CrossBindingMethodInfo<
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>>
                mset_targetsForSelection_13 =
                    new CrossBindingMethodInfo<System.Collections.Generic.List<
                        UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>>("set_targetsForSelection");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable, System.Boolean>
                mCanHover_14 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable,
                        System.Boolean>("CanHover");

            CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable, System.Boolean>
                mCanSelect_15 =
                    new CrossBindingFunctionInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable,
                        System.Boolean>("CanSelect");

            CrossBindingFunctionInfo<
                    System.Nullable<UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType>>
                mget_selectedInteractableMovementTypeOverride_16 =
                    new CrossBindingFunctionInfo<
                        System.Nullable<UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType>>(
                        "get_selectedInteractableMovementTypeOverride");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>
                mPreprocessInteractor_17 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>(
                        "PreprocessInteractor");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>
                mProcessInteractor_18 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase>(
                        "ProcessInteractor");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> mOnRegistered_19 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>(
                    "OnRegistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>
                mOnUnregistered_20 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>(
                        "OnUnregistered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntering_21 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs> mOnHoverEntered_22 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>("OnHoverEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExiting_23 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs> mOnHoverExited_24 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>("OnHoverExited");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntering_25 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntering");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs> mOnSelectEntered_26 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>("OnSelectEntered");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExiting_27 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExiting");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs> mOnSelectExited_28 =
                new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>("OnSelectExited");

            CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>
                mStartManualInteraction_29 =
                    new CrossBindingMethodInfo<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>(
                        "StartManualInteraction");

            CrossBindingMethodInfo mEndManualInteraction_30 = new CrossBindingMethodInfo("EndManualInteraction");

            CrossBindingFunctionInfo<System.Boolean> mget_requireSelectExclusive_31 =
                new CrossBindingFunctionInfo<System.Boolean>("get_requireSelectExclusive");

            CrossBindingFunctionInfo<UnityEngine.Transform> mget_transform_32 =
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

            protected override void Start()
            {
                if (instance == null) return;
                if (mStart_4.CheckShouldInvokeBase(this.instance))
                    base.Start();
                else
                    mStart_4.Invoke(this.instance);
            }

            protected override void OnDestroy()
            {
                if (instance == null) return;
                if (mOnDestroy_5.CheckShouldInvokeBase(this.instance))
                    base.OnDestroy();
                else
                    mOnDestroy_5.Invoke(this.instance);
            }

            public override UnityEngine.Transform GetAttachTransform(
                UnityEngine.XR.Interaction.Toolkit.IXRInteractable interactable)
            {
                if (instance == null) return null;
                if (mGetAttachTransform_6.CheckShouldInvokeBase(this.instance))
                    return base.GetAttachTransform(interactable);
                else
                    return mGetAttachTransform_6.Invoke(this.instance, interactable);
            }

            public override void GetValidTargets(
                System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRInteractable> targets)
            {
                if (instance == null) return;
                if (mGetValidTargets_7.CheckShouldInvokeBase(this.instance))
                    base.GetValidTargets(targets);
                else
                    mGetValidTargets_7.Invoke(this.instance, targets);
            }

            public override System.Boolean CanHover(
                UnityEngine.XR.Interaction.Toolkit.IXRHoverInteractable interactable)
            {
                if (instance == null) return false;
                if (mCanHover_14.CheckShouldInvokeBase(this.instance))
                    return base.CanHover(interactable);
                else
                    return mCanHover_14.Invoke(this.instance, interactable);
            }

            public override System.Boolean CanSelect(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable interactable)
            {
                if (instance == null) return false;
                if (mCanSelect_15.CheckShouldInvokeBase(this.instance))
                    return base.CanSelect(interactable);
                else
                    return mCanSelect_15.Invoke(this.instance, interactable);
            }

            public override void PreprocessInteractor(
                UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase)
            {
                if (instance == null) return;
                if (mPreprocessInteractor_17.CheckShouldInvokeBase(this.instance))
                    base.PreprocessInteractor(updatePhase);
                else
                    mPreprocessInteractor_17.Invoke(this.instance, updatePhase);
            }

            public override void ProcessInteractor(
                UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase updatePhase)
            {
                if (instance == null) return;
                if (mProcessInteractor_18.CheckShouldInvokeBase(this.instance))
                    base.ProcessInteractor(updatePhase);
                else
                    mProcessInteractor_18.Invoke(this.instance, updatePhase);
            }

            protected override void OnRegistered(UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnRegistered_19.CheckShouldInvokeBase(this.instance))
                    base.OnRegistered(args);
                else
                    mOnRegistered_19.Invoke(this.instance, args);
            }

            protected override void OnUnregistered(
                UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs args)
            {
                if (instance == null) return;
                if (mOnUnregistered_20.CheckShouldInvokeBase(this.instance))
                    base.OnUnregistered(args);
                else
                    mOnUnregistered_20.Invoke(this.instance, args);
            }

            protected override void OnHoverEntering(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntering_21.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntering(args);
                else
                    mOnHoverEntering_21.Invoke(this.instance, args);
            }

            protected override void OnHoverEntered(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverEntered_22.CheckShouldInvokeBase(this.instance))
                    base.OnHoverEntered(args);
                else
                    mOnHoverEntered_22.Invoke(this.instance, args);
            }

            protected override void OnHoverExiting(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExiting_23.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExiting(args);
                else
                    mOnHoverExiting_23.Invoke(this.instance, args);
            }

            protected override void OnHoverExited(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnHoverExited_24.CheckShouldInvokeBase(this.instance))
                    base.OnHoverExited(args);
                else
                    mOnHoverExited_24.Invoke(this.instance, args);
            }

            protected override void OnSelectEntering(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntering_25.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntering(args);
                else
                    mOnSelectEntering_25.Invoke(this.instance, args);
            }

            protected override void OnSelectEntered(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectEntered_26.CheckShouldInvokeBase(this.instance))
                    base.OnSelectEntered(args);
                else
                    mOnSelectEntered_26.Invoke(this.instance, args);
            }

            protected override void OnSelectExiting(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExiting_27.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExiting(args);
                else
                    mOnSelectExiting_27.Invoke(this.instance, args);
            }

            protected override void OnSelectExited(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs args)
            {
                if (instance == null) return;
                if (mOnSelectExited_28.CheckShouldInvokeBase(this.instance))
                    base.OnSelectExited(args);
                else
                    mOnSelectExited_28.Invoke(this.instance, args);
            }

            public override void StartManualInteraction(
                UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable interactable)
            {
                if (instance == null) return;
                if (mStartManualInteraction_29.CheckShouldInvokeBase(this.instance))
                    base.StartManualInteraction(interactable);
                else
                    mStartManualInteraction_29.Invoke(this.instance, interactable);
            }

            public override void EndManualInteraction()
            {
                if (instance == null) return;
                if (mEndManualInteraction_30.CheckShouldInvokeBase(this.instance))
                    base.EndManualInteraction();
                else
                    mEndManualInteraction_30.Invoke(this.instance);
            }

            public override System.Boolean isHoverActive
            {
                get
                {
                    if (instance == null) return false;
                    if (mget_isHoverActive_8.CheckShouldInvokeBase(this.instance))
                        return base.isHoverActive;
                    else
                        return mget_isHoverActive_8.Invoke(this.instance);
                }
            }

            public override System.Boolean isSelectActive
            {
                get
                {
                    if (instance == null) return false;
                    if (mget_isSelectActive_9.CheckShouldInvokeBase(this.instance))
                        return base.isSelectActive;
                    else
                        return mget_isSelectActive_9.Invoke(this.instance);
                }
            }

            public override UnityEngine.XR.Interaction.Toolkit.TargetPriorityMode targetPriorityMode
            {
                get
                {
                    if (instance == null) return TargetPriorityMode.None;
                    if (mget_targetPriorityMode_10.CheckShouldInvokeBase(this.instance))
                        return base.targetPriorityMode;
                    else
                        return mget_targetPriorityMode_10.Invoke(this.instance);
                }
                set
                {
                    if (instance == null) return;
                    if (mset_targetPriorityMode_11.CheckShouldInvokeBase(this.instance))
                        base.targetPriorityMode = value;
                    else
                        mset_targetPriorityMode_11.Invoke(this.instance, value);
                }
            }

            public override System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.IXRSelectInteractable>
                targetsForSelection
            {
                get
                {
                    if (instance == null) return new List<IXRSelectInteractable>();
                    if (mget_targetsForSelection_12.CheckShouldInvokeBase(this.instance))
                        return base.targetsForSelection;
                    else
                        return mget_targetsForSelection_12.Invoke(this.instance);
                }
                set
                {
                    if (instance == null) return;
                    if (mset_targetsForSelection_13.CheckShouldInvokeBase(this.instance))
                        base.targetsForSelection = value;
                    else
                        mset_targetsForSelection_13.Invoke(this.instance, value);
                }
            }

            public override System.Nullable<UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType>
                selectedInteractableMovementTypeOverride
            {
                get
                {
                    if (instance == null) return XRBaseInteractable.MovementType.Instantaneous;
                    if (mget_selectedInteractableMovementTypeOverride_16.CheckShouldInvokeBase(this.instance))
                        return base.selectedInteractableMovementTypeOverride;
                    else
                        return mget_selectedInteractableMovementTypeOverride_16.Invoke(this.instance);
                }
            }

            public override System.Boolean requireSelectExclusive
            {
                get
                {
                    if (instance == null) return false;
                    if (mget_requireSelectExclusive_31.CheckShouldInvokeBase(this.instance))
                        return base.requireSelectExclusive;
                    else
                        return mget_requireSelectExclusive_31.Invoke(this.instance);
                }
            }

            public UnityEngine.Transform transform
            {
                get { return mget_transform_32.Invoke(this.instance); }
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