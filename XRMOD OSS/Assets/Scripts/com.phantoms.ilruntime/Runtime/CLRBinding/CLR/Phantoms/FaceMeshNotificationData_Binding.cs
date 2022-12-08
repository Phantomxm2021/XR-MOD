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
    unsafe class FaceMeshNotificationData_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData);

            field = type.GetField("TrackingId", flag);
            app.RegisterCLRFieldGetter(field, get_TrackingId_0);
            app.RegisterCLRFieldSetter(field, set_TrackingId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TrackingId_0, AssignFromStack_TrackingId_0);
            field = type.GetField("FaceAnchor", flag);
            app.RegisterCLRFieldGetter(field, get_FaceAnchor_1);
            app.RegisterCLRFieldSetter(field, set_FaceAnchor_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FaceAnchor_1, AssignFromStack_FaceAnchor_1);
            field = type.GetField("FaceTrackingState", flag);
            app.RegisterCLRFieldGetter(field, get_FaceTrackingState_2);
            app.RegisterCLRFieldSetter(field, set_FaceTrackingState_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_FaceTrackingState_2, AssignFromStack_FaceTrackingState_2);
            field = type.GetField("vertices", flag);
            app.RegisterCLRFieldGetter(field, get_vertices_3);
            app.RegisterCLRFieldSetter(field, set_vertices_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_vertices_3, AssignFromStack_vertices_3);
            field = type.GetField("indices", flag);
            app.RegisterCLRFieldGetter(field, get_indices_4);
            app.RegisterCLRFieldSetter(field, set_indices_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_indices_4, AssignFromStack_indices_4);
            field = type.GetField("normals", flag);
            app.RegisterCLRFieldGetter(field, get_normals_5);
            app.RegisterCLRFieldSetter(field, set_normals_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_normals_5, AssignFromStack_normals_5);
            field = type.GetField("uvs", flag);
            app.RegisterCLRFieldGetter(field, get_uvs_6);
            app.RegisterCLRFieldSetter(field, set_uvs_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_uvs_6, AssignFromStack_uvs_6);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData());
            app.RegisterCLRCreateArrayInstance(type,
                s => new com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static object get_TrackingId_0(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).TrackingId;
        }

        static StackObject* CopyToStack_TrackingId_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).TrackingId;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TrackingId_0(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).TrackingId = (System.String) v;
        }

        static StackObject* AssignFromStack_TrackingId_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @TrackingId =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain,
                    __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).TrackingId = @TrackingId;
            return ptr_of_this_method;
        }

        static object get_FaceAnchor_1(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceAnchor;
        }

        static StackObject* CopyToStack_FaceAnchor_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceAnchor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FaceAnchor_1(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceAnchor =
                (UnityEngine.GameObject) v;
        }

        static StackObject* AssignFromStack_FaceAnchor_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @FaceAnchor =
                (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceAnchor = @FaceAnchor;
            return ptr_of_this_method;
        }

        static object get_FaceTrackingState_2(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceTrackingState;
        }

        static StackObject* CopyToStack_FaceTrackingState_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceTrackingState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FaceTrackingState_2(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceTrackingState =
                (com.Phantoms.ActionNotification.Runtime.FaceTrackingState) v;
        }

        static StackObject* AssignFromStack_FaceTrackingState_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            com.Phantoms.ActionNotification.Runtime.FaceTrackingState @FaceTrackingState =
                (com.Phantoms.ActionNotification.Runtime.FaceTrackingState)
                typeof(com.Phantoms.ActionNotification.Runtime.FaceTrackingState).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).FaceTrackingState =
                @FaceTrackingState;
            return ptr_of_this_method;
        }

        static object get_vertices_3(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).vertices;
        }

        static StackObject* CopyToStack_vertices_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).vertices;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_vertices_3(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).vertices =
                (Unity.Collections.NativeArray<UnityEngine.Vector3>) v;
        }

        static StackObject* AssignFromStack_vertices_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<UnityEngine.Vector3> @vertices =
                (Unity.Collections.NativeArray<UnityEngine.Vector3>)
                typeof(Unity.Collections.NativeArray<UnityEngine.Vector3>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).vertices = @vertices;
            return ptr_of_this_method;
        }

        static object get_indices_4(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).indices;
        }

        static StackObject* CopyToStack_indices_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).indices;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_indices_4(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).indices =
                (Unity.Collections.NativeArray<System.Int32>) v;
        }

        static StackObject* AssignFromStack_indices_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<System.Int32> @indices =
                (Unity.Collections.NativeArray<System.Int32>) typeof(Unity.Collections.NativeArray<System.Int32>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).indices = @indices;
            return ptr_of_this_method;
        }

        static object get_normals_5(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).normals;
        }

        static StackObject* CopyToStack_normals_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).normals;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_normals_5(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).normals =
                (Unity.Collections.NativeArray<UnityEngine.Vector3>) v;
        }

        static StackObject* AssignFromStack_normals_5(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<UnityEngine.Vector3> @normals =
                (Unity.Collections.NativeArray<UnityEngine.Vector3>)
                typeof(Unity.Collections.NativeArray<UnityEngine.Vector3>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).normals = @normals;
            return ptr_of_this_method;
        }

        static object get_uvs_6(ref object o)
        {
            return ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).uvs;
        }

        static StackObject* CopyToStack_uvs_6(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).uvs;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_uvs_6(ref object o, object v)
        {
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).uvs =
                (Unity.Collections.NativeArray<UnityEngine.Vector2>) v;
        }

        static StackObject* AssignFromStack_uvs_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method,
            AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<UnityEngine.Vector2> @uvs =
                (Unity.Collections.NativeArray<UnityEngine.Vector2>)
                typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData) o).uvs = @uvs;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new com.Phantoms.ActionNotification.Runtime.FaceMeshNotificationData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}