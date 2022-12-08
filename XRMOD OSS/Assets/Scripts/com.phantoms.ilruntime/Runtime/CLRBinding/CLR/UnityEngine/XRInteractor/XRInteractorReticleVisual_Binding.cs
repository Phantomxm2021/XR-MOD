using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif

namespace ILRuntime.Runtime.Generated
{
    unsafe class XRInteractorReticleVisual_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual);
            args = new Type[]{};
            method = type.GetMethod("get_maxRaycastDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxRaycastDistance_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxRaycastDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxRaycastDistance_1);
            args = new Type[]{};
            method = type.GetMethod("get_reticlePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reticlePrefab_2);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_reticlePrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reticlePrefab_3);
            args = new Type[]{};
            method = type.GetMethod("get_prefabScalingFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_prefabScalingFactor_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_prefabScalingFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_prefabScalingFactor_5);
            args = new Type[]{};
            method = type.GetMethod("get_undoDistanceScaling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_undoDistanceScaling_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_undoDistanceScaling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_undoDistanceScaling_7);
            args = new Type[]{};
            method = type.GetMethod("get_alignPrefabWithSurfaceNormal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_alignPrefabWithSurfaceNormal_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_alignPrefabWithSurfaceNormal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_alignPrefabWithSurfaceNormal_9);
            args = new Type[]{};
            method = type.GetMethod("get_endpointSmoothingTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_endpointSmoothingTime_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_endpointSmoothingTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_endpointSmoothingTime_11);
            args = new Type[]{};
            method = type.GetMethod("get_drawWhileSelecting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drawWhileSelecting_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_drawWhileSelecting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drawWhileSelecting_13);
            args = new Type[]{};
            method = type.GetMethod("get_raycastMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_raycastMask_14);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_raycastMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_raycastMask_15);
            args = new Type[]{};
            method = type.GetMethod("get_reticleActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reticleActive_16);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_reticleActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reticleActive_17);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_maxRaycastDistance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxRaycastDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxRaycastDistance_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxRaycastDistance = value;

            return __ret;
        }

        static StackObject* get_reticlePrefab_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reticlePrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reticlePrefab_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reticlePrefab = value;

            return __ret;
        }

        static StackObject* get_prefabScalingFactor_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.prefabScalingFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_prefabScalingFactor_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.prefabScalingFactor = value;

            return __ret;
        }

        static StackObject* get_undoDistanceScaling_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.undoDistanceScaling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_undoDistanceScaling_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.undoDistanceScaling = value;

            return __ret;
        }

        static StackObject* get_alignPrefabWithSurfaceNormal_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.alignPrefabWithSurfaceNormal;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_alignPrefabWithSurfaceNormal_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.alignPrefabWithSurfaceNormal = value;

            return __ret;
        }

        static StackObject* get_endpointSmoothingTime_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.endpointSmoothingTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_endpointSmoothingTime_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endpointSmoothingTime = value;

            return __ret;
        }

        static StackObject* get_drawWhileSelecting_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drawWhileSelecting;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_drawWhileSelecting_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawWhileSelecting = value;

            return __ret;
        }

        static StackObject* get_raycastMask_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.raycastMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_raycastMask_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.raycastMask = value;

            return __ret;
        }

        static StackObject* get_reticleActive_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reticleActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_reticleActive_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual instance_of_this_method = (UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual)typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reticleActive = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Interaction.Toolkit.XRInteractorReticleVisual();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
