using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class ARMODAPI_Runtime_API_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(com.Phantoms.ARMODAPI.Runtime.API);
            args = new Type[] { };
            method = type.GetMethod("IsPointerOverUi", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPointerOverUi_0);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("SaveKeyAndValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveKeyAndValue_1);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetValueByKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetValueByKey_2);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("RemoveKeyAndValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveKeyAndValue_3);
            args = new Type[] { };
            method = type.GetMethod("GetDeviceInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDeviceInfo_4);
            args = new Type[] { };
            method = type.GetMethod("GetSystemLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSystemLanguage_5);
            args = new Type[] {typeof(UnityEngine.ScreenOrientation)};
            method = type.GetMethod("SetScreenOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetScreenOrientation_6);
#if UNITY_IOS || UNITY_ANDROID
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("ResizeARWorldScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResizeARWorldScale_7);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireSDKVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireSDKVersion_8);
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)};
            method = type.GetMethod("ChangeARAlgorithmLife", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeARAlgorithmLife_9);
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)};
            method = type.GetMethod("StickObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StickObject_10);
            args = new Type[]
                {typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("MakeContentAppearAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MakeContentAppearAt_11);
            args = new Type[]
            {
                typeof(UnityEngine.Vector3), typeof(com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum),
                typeof(System.Action<UnityEngine.Pose>)
            };
            method = type.GetMethod("ARRaycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ARRaycast_12);
            args = new Type[] { };
            method = type.GetMethod("Exit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Exit_13);
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)};
            method = type.GetMethod("TryAcquireCurrentFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireCurrentFrame_14);
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)};
            method = type.GetMethod("TryAcquireAROcclusionFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireAROcclusionFrame_15);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireLightEstimateValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireLightEstimateValue_16);
            args = new Type[] { };
            method = type.GetMethod("CheckARAvailability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CheckARAvailability_17);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("CheckFeatureAvailability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CheckFeatureAvailability_18);
#endif
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.OpenBuiltInNotificationData)};
            method = type.GetMethod("OpenBuiltInBrowser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenBuiltInBrowser_19);
            args = new Type[] {typeof(com.Phantoms.ActionNotification.Runtime.TryAcquireAppInfoNotificationData)};
            method = type.GetMethod("TryAcquireAppInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireAppInfo_20);

            args = new Type[] {typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("MediaRecorder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MediaRecorder_21);

            args = new Type[] { };
            method = type.GetMethod("TryAcquireProjectUid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireProjectUid_23);

            args = new Type[] { };
            method = type.GetMethod("TryAcquireTemporaryCachePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireTemporaryCachePath_26);

            args = new Type[] { };
            method = type.GetMethod("TryAcquireSdkType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireSdkType_27);

            args = new Type[] {typeof(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)};
            method = type.GetMethod("OverrideRenderPipelineAtRuntime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverrideRenderPipelineAtRuntime_22);

            args = new Type[] {typeof(System.String), typeof(System.Action<UnityEngine.GameObject>)};
            method = type.GetMethod("TryAcquireNetworkMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireNetworkMesh_24);

            args = new Type[] {typeof(System.String), typeof(System.Action<string>)};
            method = type.GetMethod("TryAcquireNetworkMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireNetworkMesh_28);

            args = new Type[] {typeof(UnityEngine.Material)};
            method = type.GetMethod("OverrideSkyBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverrideSkyBox_25);

            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SendMessageToSDK", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendMessageToSDK_26);
            
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("TryAcquireLaunchConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireLaunchConfig);
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ARMODAPI.Runtime.API[s]);

            args = new Type[] {typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* IsPointerOverUi_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPointerOverUi();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SaveKeyAndValue_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_value = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SaveKeyAndValue(@_key, @_value);

            return __ret;
        }

        static StackObject* GetValueByKey_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetValueByKey(@_key);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveKeyAndValue_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveKeyAndValue(@_key);

            return __ret;
        }

        static StackObject* GetDeviceInfo_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDeviceInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSystemLanguage_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSystemLanguage();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetScreenOrientation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ScreenOrientation @_orientation =
                (UnityEngine.ScreenOrientation) typeof(UnityEngine.ScreenOrientation).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetScreenOrientation(@_orientation);

            return __ret;
        }
#if UNITY_IOS || UNITY_ANDROID
        static StackObject* ResizeARWorldScale_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_worldScale = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResizeARWorldScale(@_worldScale);

            return __ret;
        }

        static StackObject* TryAcquireSDKVersion_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireSDKVersion();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ChangeARAlgorithmLife_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData @_data =
                (com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.ARAlgorithmNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeARAlgorithmLife(@_data);

            return __ret;
        }

        static StackObject* StickObject_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.AnchorNotificationData @_anchorNotification =
                (com.Phantoms.ActionNotification.Runtime.AnchorNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.AnchorNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StickObject(@_anchorNotification);

            return __ret;
        }

        static StackObject* MakeContentAppearAt_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @_contentTrans = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MakeContentAppearAt(@_contentTrans, @_position, @_rotation);

            return __ret;
        }

        static StackObject* ARRaycast_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Pose> @_callback =
                (System.Action<UnityEngine.Pose>) typeof(System.Action<UnityEngine.Pose>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum @_trackableType =
                (com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum)
                typeof(com.Phantoms.ActionNotification.Runtime.TrackableTypeEnum).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @_screen = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ARRaycast(@_screen, @_trackableType, @_callback);

            return __ret;
        }

        static StackObject* Exit_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Exit();

            return __ret;
        }

        static StackObject* TryAcquireCurrentFrame_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData @_data =
                (com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireCurrentFrame(@_data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireAROcclusionFrame_15(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData @_data =
                (com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.AROcclusionNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireAROcclusionFrame(@_data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireLightEstimateValue_16(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireLightEstimateValue();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CheckARAvailability_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CheckARAvailability();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CheckFeatureAvailability_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_featureName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CheckFeatureAvailability(@_featureName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
#endif
        static StackObject* OpenBuiltInBrowser_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.OpenBuiltInNotificationData @_data =
                (com.Phantoms.ActionNotification.Runtime.OpenBuiltInNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.OpenBuiltInNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OpenBuiltInBrowser(@_data);

            return __ret;
        }

        static StackObject* TryAcquireAppInfo_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ActionNotification.Runtime.TryAcquireAppInfoNotificationData @_data =
                (com.Phantoms.ActionNotification.Runtime.TryAcquireAppInfoNotificationData)
                typeof(com.Phantoms.ActionNotification.Runtime.TryAcquireAppInfoNotificationData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TryAcquireAppInfo(@_data);

            return __ret;
        }

        static StackObject* MediaRecorder_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_takePhotoMode = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_stop = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MediaRecorder(@_stop, @_takePhotoMode);

            return __ret;
        }

        static StackObject* OverrideRenderPipelineAtRuntime_22(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset @_pipelineAsset =
                (UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)
                typeof(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OverrideRenderPipelineAtRuntime(@_pipelineAsset);

            return __ret;
        }

        static StackObject* TryAcquireProjectUid_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireProjectInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* TryAcquireTemporaryCachePath_26(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireTemporaryCachePath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireSdkType_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireSdkType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireNetworkMesh_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.GameObject> @_result =
                (System.Action<UnityEngine.GameObject>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_url = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TryAcquireNetworkMesh(@_url, @_result);

            return __ret;
        }

        static StackObject* TryAcquireNetworkMesh_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<string> @_result = (System.Action<string>) typeof(System.Action<string>).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_url = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DownloadNetworkMesh(@_url, @_result);

            return __ret;
        }

        static StackObject* OverrideSkyBox_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @_material = (UnityEngine.Material) typeof(UnityEngine.Material).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OverrideSkyBox(@_material);

            return __ret;
        }

        static StackObject* SendMessageToSDK_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendMessageToSDK(@_data);

            return __ret;
        }

        static StackObject* TryAcquireLaunchConfig(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            com.Phantoms.ARMODAPI.Runtime.API instance_of_this_method =
                (com.Phantoms.ARMODAPI.Runtime.API) typeof(com.Phantoms.ARMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireLaunchConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_projectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new com.Phantoms.ARMODAPI.Runtime.API(@_projectName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}