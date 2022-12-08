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
    unsafe class Universal_CameraExtensions_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.Universal.CameraExtensions);
            args = new Type[]{typeof(UnityEngine.Camera)};
            method = type.GetMethod("GetUniversalAdditionalCameraData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUniversalAdditionalCameraData_0);
            args = new Type[]{typeof(UnityEngine.Camera)};
            method = type.GetMethod("GetVolumeFrameworkUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVolumeFrameworkUpdateMode_1);
            args = new Type[]{typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode)};
            method = type.GetMethod("SetVolumeFrameworkUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetVolumeFrameworkUpdateMode_2);
            args = new Type[]{typeof(UnityEngine.Camera)};
            method = type.GetMethod("UpdateVolumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateVolumeStack_3);
            args = new Type[]{typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)};
            method = type.GetMethod("UpdateVolumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateVolumeStack_4);
            args = new Type[]{typeof(UnityEngine.Camera)};
            method = type.GetMethod("DestroyVolumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyVolumeStack_5);
            args = new Type[]{typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)};
            method = type.GetMethod("DestroyVolumeStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyVolumeStack_6);





        }


        static StackObject* GetUniversalAdditionalCameraData_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.Universal.CameraExtensions.GetUniversalAdditionalCameraData(@camera);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetVolumeFrameworkUpdateMode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.Universal.CameraExtensions.GetVolumeFrameworkUpdateMode(@camera);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetVolumeFrameworkUpdateMode_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode @mode = (UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode)typeof(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.Universal.CameraExtensions.SetVolumeFrameworkUpdateMode(@camera, @mode);

            return __ret;
        }

        static StackObject* UpdateVolumeStack_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.Universal.CameraExtensions.UpdateVolumeStack(@camera);

            return __ret;
        }

        static StackObject* UpdateVolumeStack_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData @cameraData = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.Universal.CameraExtensions.UpdateVolumeStack(@camera, @cameraData);

            return __ret;
        }

        static StackObject* DestroyVolumeStack_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.Universal.CameraExtensions.DestroyVolumeStack(@camera);

            return __ret;
        }

        static StackObject* DestroyVolumeStack_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalAdditionalCameraData @cameraData = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.Universal.CameraExtensions.DestroyVolumeStack(@camera, @cameraData);

            return __ret;
        }





    }
}
