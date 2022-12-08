using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.TypeSystem;
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
    unsafe class CreatePrefabMessage_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            FieldInfo field;
            
            Type type = typeof(com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData);

            field = type.GetField("PrefabName", flag);
            app.RegisterCLRFieldGetter(field, get_PrefabName_0);
            app.RegisterCLRFieldSetter(field, set_PrefabName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PrefabName_0, AssignFromStack_PrefabName_0);
            field = type.GetField("IsPlayerBinding", flag);
            app.RegisterCLRFieldGetter(field, get_IsPlayerBinding_1);
            app.RegisterCLRFieldSetter(field, set_IsPlayerBinding_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPlayerBinding_1, AssignFromStack_IsPlayerBinding_1);
            field = type.GetField("WorldPos", flag);
            app.RegisterCLRFieldGetter(field, get_WorldPos_2);
            app.RegisterCLRFieldSetter(field, set_WorldPos_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_WorldPos_2, AssignFromStack_WorldPos_2);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_3);
            app.RegisterCLRFieldSetter(field, set_Position_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_3, AssignFromStack_Position_3);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_4);
            app.RegisterCLRFieldSetter(field, set_Rotation_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_4, AssignFromStack_Rotation_4);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type,
                () => new com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData());
            app.RegisterCLRCreateArrayInstance(type,
                s => new com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData[s]);
        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method,
            AutoList __mStack,
            ref com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                {
                    __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
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
                    if (t is ILType)
                    {
                        ((ILType) t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        ((CLRType) t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }


        static object get_PrefabName_0(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).PrefabName;
        }

        static StackObject* CopyToStack_PrefabName_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).PrefabName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PrefabName_0(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.PrefabName = (System.String) v;
            o = ins;
        }

        static StackObject* AssignFromStack_PrefabName_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @PrefabName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.PrefabName = @PrefabName;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_IsPlayerBinding_1(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).IsPlayerBinding;
        }

        static StackObject* CopyToStack_IsPlayerBinding_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).IsPlayerBinding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPlayerBinding_1(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.IsPlayerBinding = (System.Boolean) v;
            o = ins;
        }

        static StackObject* AssignFromStack_IsPlayerBinding_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPlayerBinding = ptr_of_this_method->Value == 1;
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.IsPlayerBinding = @IsPlayerBinding;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_WorldPos_2(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).WorldPos;
        }

        static StackObject* CopyToStack_WorldPos_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).WorldPos;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_WorldPos_2(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.WorldPos = (System.Boolean) v;
            o = ins;
        }

        static StackObject* AssignFromStack_WorldPos_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @WorldPos = ptr_of_this_method->Value == 1;
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.WorldPos = @WorldPos;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Position_3(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).Position;
        }

        static StackObject* CopyToStack_Position_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_3(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.Position = (UnityEngine.Vector3) v;
            o = ins;
        }

        static StackObject* AssignFromStack_Position_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.Position = @Position;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Rotation_4(ref object o)
        {
            return ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_4(ref object o, object v)
        {
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.Rotation = (UnityEngine.Quaternion) v;
            o = ins;
        }

        static StackObject* AssignFromStack_Rotation_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData ins =
                (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            ins.Rotation = @Rotation;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData();
            ins = (com.PhantomsXR.MirrorExtension.Runtime.CreatePrefabData) o;
            return ins;
        }
    }
}