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
    unsafe class UniversalAdditionalCameraData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData);
            args = new Type[]{};
            method = type.GetMethod("get_version", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_version_0);
            args = new Type[]{};
            method = type.GetMethod("get_renderShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderShadows_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_renderShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderShadows_2);
            args = new Type[]{};
            method = type.GetMethod("get_requiresDepthOption", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requiresDepthOption_3);
            args = new Type[]{typeof(UnityEngine.Rendering.Universal.CameraOverrideOption)};
            method = type.GetMethod("set_requiresDepthOption", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requiresDepthOption_4);
            args = new Type[]{};
            method = type.GetMethod("get_requiresColorOption", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requiresColorOption_5);
            args = new Type[]{typeof(UnityEngine.Rendering.Universal.CameraOverrideOption)};
            method = type.GetMethod("set_requiresColorOption", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requiresColorOption_6);
            args = new Type[]{};
            method = type.GetMethod("get_renderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderType_7);
            args = new Type[]{typeof(UnityEngine.Rendering.Universal.CameraRenderType)};
            method = type.GetMethod("set_renderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderType_8);
            args = new Type[]{};
            method = type.GetMethod("get_cameraStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraStack_9);
            args = new Type[]{};
            method = type.GetMethod("get_clearDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clearDepth_10);
            args = new Type[]{};
            method = type.GetMethod("get_requiresDepthTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requiresDepthTexture_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_requiresDepthTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requiresDepthTexture_12);
            args = new Type[]{};
            method = type.GetMethod("get_requiresColorTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requiresColorTexture_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_requiresColorTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requiresColorTexture_14);
            args = new Type[]{};
            method = type.GetMethod("get_scriptableRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scriptableRenderer_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderer_16);
            args = new Type[]{};
            method = type.GetMethod("get_volumeLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_volumeLayerMask_17);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_volumeLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_volumeLayerMask_18);
            args = new Type[]{};
            method = type.GetMethod("get_volumeTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_volumeTrigger_19);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_volumeTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_volumeTrigger_20);
            args = new Type[]{};
            method = type.GetMethod("get_requiresVolumeFrameworkUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requiresVolumeFrameworkUpdate_21);
            args = new Type[]{};
            method = type.GetMethod("get_volumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_volumeStack_22);
            args = new Type[]{typeof(UnityEngine.Rendering.VolumeStack)};
            method = type.GetMethod("set_volumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_volumeStack_23);
            args = new Type[]{};
            method = type.GetMethod("get_renderPostProcessing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderPostProcessing_24);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_renderPostProcessing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderPostProcessing_25);
            args = new Type[]{};
            method = type.GetMethod("get_antialiasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_antialiasing_26);
            args = new Type[]{typeof(UnityEngine.Rendering.Universal.AntialiasingMode)};
            method = type.GetMethod("set_antialiasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_antialiasing_27);
            args = new Type[]{};
            method = type.GetMethod("get_antialiasingQuality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_antialiasingQuality_28);
            args = new Type[]{typeof(UnityEngine.Rendering.Universal.AntialiasingQuality)};
            method = type.GetMethod("set_antialiasingQuality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_antialiasingQuality_29);
            args = new Type[]{};
            method = type.GetMethod("get_stopNaN", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stopNaN_30);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_stopNaN", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stopNaN_31);
            args = new Type[]{};
            method = type.GetMethod("get_dithering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dithering_32);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_dithering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_dithering_33);
            args = new Type[]{};
            method = type.GetMethod("get_allowXRRendering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowXRRendering_34);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_allowXRRendering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowXRRendering_35);
            args = new Type[]{};
            method = type.GetMethod("OnBeforeSerialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBeforeSerialize_36);
            args = new Type[]{};
            method = type.GetMethod("OnAfterDeserialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAfterDeserialize_37);
            args = new Type[]{};
            method = type.GetMethod("OnDrawGizmos", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDrawGizmos_38);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rendering.Universal.UniversalAdditionalCameraData());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rendering.Universal.UniversalAdditionalCameraData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_version_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.version;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_renderShadows_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_renderShadows_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderShadows = value;

            return __ret;
        }

        static StackObject* get_requiresDepthOption_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requiresDepthOption;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requiresDepthOption_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.CameraOverrideOption @value = (UnityEngine.Rendering.Universal.CameraOverrideOption)typeof(UnityEngine.Rendering.Universal.CameraOverrideOption).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requiresDepthOption = value;

            return __ret;
        }

        static StackObject* get_requiresColorOption_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requiresColorOption;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requiresColorOption_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.CameraOverrideOption @value = (UnityEngine.Rendering.Universal.CameraOverrideOption)typeof(UnityEngine.Rendering.Universal.CameraOverrideOption).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requiresColorOption = value;

            return __ret;
        }

        static StackObject* get_renderType_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderType_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.CameraRenderType @value = (UnityEngine.Rendering.Universal.CameraRenderType)typeof(UnityEngine.Rendering.Universal.CameraRenderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderType = value;

            return __ret;
        }

        static StackObject* get_cameraStack_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cameraStack;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_clearDepth_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clearDepth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_requiresDepthTexture_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requiresDepthTexture;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_requiresDepthTexture_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requiresDepthTexture = value;

            return __ret;
        }

        static StackObject* get_requiresColorTexture_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requiresColorTexture;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_requiresColorTexture_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requiresColorTexture = value;

            return __ret;
        }

        static StackObject* get_scriptableRenderer_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scriptableRenderer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetRenderer_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderer(@index);

            return __ret;
        }

        static StackObject* get_volumeLayerMask_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.volumeLayerMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_volumeLayerMask_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.volumeLayerMask = value;

            return __ret;
        }

        static StackObject* get_volumeTrigger_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.volumeTrigger;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_volumeTrigger_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.volumeTrigger = value;

            return __ret;
        }

        static StackObject* get_requiresVolumeFrameworkUpdate_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requiresVolumeFrameworkUpdate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_volumeStack_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.volumeStack;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_volumeStack_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.VolumeStack @value = (UnityEngine.Rendering.VolumeStack)typeof(UnityEngine.Rendering.VolumeStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.volumeStack = value;

            return __ret;
        }

        static StackObject* get_renderPostProcessing_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderPostProcessing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_renderPostProcessing_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderPostProcessing = value;

            return __ret;
        }

        static StackObject* get_antialiasing_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.antialiasing;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_antialiasing_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.AntialiasingMode @value = (UnityEngine.Rendering.Universal.AntialiasingMode)typeof(UnityEngine.Rendering.Universal.AntialiasingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.antialiasing = value;

            return __ret;
        }

        static StackObject* get_antialiasingQuality_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.antialiasingQuality;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_antialiasingQuality_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.AntialiasingQuality @value = (UnityEngine.Rendering.Universal.AntialiasingQuality)typeof(UnityEngine.Rendering.Universal.AntialiasingQuality).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.antialiasingQuality = value;

            return __ret;
        }

        static StackObject* get_stopNaN_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stopNaN;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_stopNaN_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stopNaN = value;

            return __ret;
        }

        static StackObject* get_dithering_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.dithering;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_dithering_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.dithering = value;

            return __ret;
        }

        static StackObject* get_allowXRRendering_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowXRRendering;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowXRRendering_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowXRRendering = value;

            return __ret;
        }

        static StackObject* OnBeforeSerialize_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBeforeSerialize();

            return __ret;
        }

        static StackObject* OnAfterDeserialize_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAfterDeserialize();

            return __ret;
        }

        static StackObject* OnDrawGizmos_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData instance_of_this_method = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDrawGizmos();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Rendering.Universal.UniversalAdditionalCameraData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
