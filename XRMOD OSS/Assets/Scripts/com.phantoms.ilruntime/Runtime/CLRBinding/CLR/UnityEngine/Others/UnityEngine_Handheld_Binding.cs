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
    unsafe class UnityEngine_Handheld_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Handheld);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color), typeof(UnityEngine.FullScreenMovieControlMode), typeof(UnityEngine.FullScreenMovieScalingMode)};
            method = type.GetMethod("PlayFullScreenMovie", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayFullScreenMovie_0);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color), typeof(UnityEngine.FullScreenMovieControlMode)};
            method = type.GetMethod("PlayFullScreenMovie", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayFullScreenMovie_1);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color)};
            method = type.GetMethod("PlayFullScreenMovie", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayFullScreenMovie_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("PlayFullScreenMovie", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayFullScreenMovie_3);
            args = new Type[]{};
            method = type.GetMethod("Vibrate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Vibrate_4);
            // args = new Type[]{typeof(UnityEngine.iOS.ActivityIndicatorStyle)};
            // method = type.GetMethod("SetActivityIndicatorStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetActivityIndicatorStyle_5);
            // args = new Type[]{typeof(UnityEngine.AndroidActivityIndicatorStyle)};
            // method = type.GetMethod("SetActivityIndicatorStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetActivityIndicatorStyle_6);
            // args = new Type[]{};
            // method = type.GetMethod("GetActivityIndicatorStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetActivityIndicatorStyle_7);
            // args = new Type[]{};
            // method = type.GetMethod("StartActivityIndicator", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, StartActivityIndicator_8);
            // args = new Type[]{};
            // method = type.GetMethod("StopActivityIndicator", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, StopActivityIndicator_9);
            args = new Type[]{};
            method = type.GetMethod("ClearShaderCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearShaderCache_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Handheld());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Handheld[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* PlayFullScreenMovie_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FullScreenMovieScalingMode @scalingMode = (UnityEngine.FullScreenMovieScalingMode)typeof(UnityEngine.FullScreenMovieScalingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.FullScreenMovieControlMode @controlMode = (UnityEngine.FullScreenMovieControlMode)typeof(UnityEngine.FullScreenMovieControlMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color @bgColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Handheld.PlayFullScreenMovie(@path, @bgColor, @controlMode, @scalingMode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* PlayFullScreenMovie_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FullScreenMovieControlMode @controlMode = (UnityEngine.FullScreenMovieControlMode)typeof(UnityEngine.FullScreenMovieControlMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color @bgColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Handheld.PlayFullScreenMovie(@path, @bgColor, @controlMode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* PlayFullScreenMovie_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @bgColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Handheld.PlayFullScreenMovie(@path, @bgColor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* PlayFullScreenMovie_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Handheld.PlayFullScreenMovie(@path);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Vibrate_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Handheld.Vibrate();

            return __ret;
        }

        // static StackObject* SetActivityIndicatorStyle_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.iOS.ActivityIndicatorStyle @style = (UnityEngine.iOS.ActivityIndicatorStyle)typeof(UnityEngine.iOS.ActivityIndicatorStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     UnityEngine.Handheld.SetActivityIndicatorStyle(@style);
        //
        //     return __ret;
        // }

        // static StackObject* SetActivityIndicatorStyle_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.AndroidActivityIndicatorStyle @style = (UnityEngine.AndroidActivityIndicatorStyle)typeof(UnityEngine.AndroidActivityIndicatorStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     UnityEngine.Handheld.SetActivityIndicatorStyle(@style);
        //
        //     return __ret;
        // }

        // static StackObject* GetActivityIndicatorStyle_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 0);
        //
        //
        //     var result_of_this_method = UnityEngine.Handheld.GetActivityIndicatorStyle();
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }

        // static StackObject* StartActivityIndicator_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 0);
        //
        //
        //     UnityEngine.Handheld.StartActivityIndicator();
        //
        //     return __ret;
        // }

        // static StackObject* StopActivityIndicator_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 0);
        //
        //
        //     UnityEngine.Handheld.StopActivityIndicator();
        //
        //     return __ret;
        // }

        static StackObject* ClearShaderCache_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Handheld.ClearShaderCache();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Handheld();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
