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
    unsafe class TransformData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.TransformData);

            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_0);
            app.RegisterCLRFieldSetter(field, set_Position_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_0, AssignFromStack_Position_0);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_1);
            app.RegisterCLRFieldSetter(field, set_Rotation_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_1, AssignFromStack_Rotation_1);
            field = type.GetField("Scale", flag);
            app.RegisterCLRFieldGetter(field, get_Scale_2);
            app.RegisterCLRFieldSetter(field, set_Scale_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scale_2, AssignFromStack_Scale_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new com.PhantomsXR.MirrorExtension.Runtime.TransformData());
            app.RegisterCLRCreateArrayInstance(type, s => new com.PhantomsXR.MirrorExtension.Runtime.TransformData[s]);


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref com.PhantomsXR.MirrorExtension.Runtime.TransformData instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as com.PhantomsXR.MirrorExtension.Runtime.TransformData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Position_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Position;
        }

        static StackObject* CopyToStack_Position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_0(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Position = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Position_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Position = @Position;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Rotation_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_1(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Rotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Rotation_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Rotation = @Rotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Scale_2(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Scale;
        }

        static StackObject* CopyToStack_Scale_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.TransformData)o).Scale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Scale_2(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Scale = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Scale_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Scale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            com.PhantomsXR.MirrorExtension.Runtime.TransformData ins =(com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            ins.Scale = @Scale;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new com.PhantomsXR.MirrorExtension.Runtime.TransformData();
            ins = (com.PhantomsXR.MirrorExtension.Runtime.TransformData)o;
            return ins;
        }


    }
}
