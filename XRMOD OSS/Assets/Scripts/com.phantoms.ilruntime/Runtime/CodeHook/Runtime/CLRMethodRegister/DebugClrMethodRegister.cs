// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the ILRuntime.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace com.Phantoms.ILRuntime.Runtime
{
    public class DebugClrMethodRegister : AbstractRegister
    {
        public override unsafe void Register(AppDomain _appDomain)
        {
            base.Register(_appDomain);
            Type tmp_DebugType = typeof(Debug);
            var tmp_LOGMethod = tmp_DebugType.GetMethod("Log", new[] {typeof(object)});
            _appDomain.RegisterCLRMethodRedirection(tmp_LOGMethod, Log);
            var tmp_LOGWarningMethod = tmp_DebugType.GetMethod("LogWarning", new[] {typeof(object)});
            _appDomain.RegisterCLRMethodRedirection(tmp_LOGWarningMethod, LogWarning);
            var tmp_LOGErrorMethod = tmp_DebugType.GetMethod("LogError", new[] {typeof(object)});
            _appDomain.RegisterCLRMethodRedirection(tmp_LOGErrorMethod, LogError);
        }

        /// <summary>
        /// Debug.Log
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* Log(ILIntepreter __intp, StackObject* __esp,AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object tmp_Message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_Stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.Log(tmp_Message + "\n\n==========StackTrace==========\n" + tmp_Stacktrace);
            return __ret;
        }

        /// <summary>
        /// Debug.LogError
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* LogError(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_Stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogError(message + "\n\n==========StackTrace==========\n" + tmp_Stacktrace);
            return __ret;
        }

        /// <summary>
        /// Debug.LogWarning
        /// </summary>
        /// <param name="__intp"></param>
        /// <param name="__esp"></param>
        /// <param name="__mStack"></param>
        /// <param name="__method"></param>
        /// <param name="isNewObj"></param>
        /// <returns></returns>
        private unsafe StackObject* LogWarning(ILIntepreter __intp, StackObject* __esp,
            AutoList  __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

            object tmp_Message =
                typeof(object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var tmp_Stacktrace = __domain.DebugService.GetStackTrace(__intp);
            Debug.LogWarning(tmp_Message + "\n\n==========StackTrace==========\n" + tmp_Stacktrace);
            return __ret;
        }
    }
}