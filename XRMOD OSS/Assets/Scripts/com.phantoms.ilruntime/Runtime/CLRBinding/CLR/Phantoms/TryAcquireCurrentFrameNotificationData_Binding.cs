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
    unsafe class TryAcquireCurrentFrameNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData);

            field = type.GetField("AcquiredTextureFormat", flag);
            app.RegisterCLRFieldGetter(field, get_AcquiredTextureFormat_0);
            app.RegisterCLRFieldSetter(field, set_AcquiredTextureFormat_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AcquiredTextureFormat_0, AssignFromStack_AcquiredTextureFormat_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AcquiredTextureFormat_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)o).AcquiredTextureFormat;
        }

        static StackObject* CopyToStack_AcquiredTextureFormat_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)o).AcquiredTextureFormat;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AcquiredTextureFormat_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)o).AcquiredTextureFormat = (UnityEngine.TextureFormat)v;
        }

        static StackObject* AssignFromStack_AcquiredTextureFormat_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.TextureFormat @AcquiredTextureFormat = (UnityEngine.TextureFormat)typeof(UnityEngine.TextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData)o).AcquiredTextureFormat = @AcquiredTextureFormat;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.TryAcquireCurrentFrameNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
