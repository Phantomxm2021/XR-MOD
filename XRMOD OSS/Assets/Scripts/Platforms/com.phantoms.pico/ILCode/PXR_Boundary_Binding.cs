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
    unsafe class PXR_Boundary_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.XR.PXR.PXR_Boundary);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetVisible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetVisible_0);
            args = new Type[]{};
            method = type.GetMethod("GetVisible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVisible_1);
            args = new Type[]{};
            method = type.GetMethod("GetConfigured", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetConfigured_2);
            args = new Type[]{};
            method = type.GetMethod("GetEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnabled_3);
            args = new Type[]{typeof(Unity.XR.PXR.BoundaryTrackingNode), typeof(Unity.XR.PXR.BoundaryType)};
            method = type.GetMethod("TestNode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TestNode_4);
            args = new Type[]{typeof(Unity.XR.PXR.PxrVector3f), typeof(Unity.XR.PXR.BoundaryType)};
            method = type.GetMethod("TestPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TestPoint_5);
            args = new Type[]{typeof(Unity.XR.PXR.BoundaryType)};
            method = type.GetMethod("GetGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGeometry_6);
            args = new Type[]{typeof(Unity.XR.PXR.BoundaryType)};
            method = type.GetMethod("GetDimensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDimensions_7);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("EnableSeeThroughManual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableSeeThroughManual_8);
            args = new Type[]{};
            method = type.GetMethod("GetDialogState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDialogState_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.XR.PXR.PXR_Boundary());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.XR.PXR.PXR_Boundary[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetVisible_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            Unity.XR.PXR.PXR_Boundary.SetVisible(@value);

            return __ret;
        }

        static StackObject* GetVisible_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetVisible();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetConfigured_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetConfigured();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetEnabled_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetEnabled();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TestNode_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.BoundaryType @boundaryType = (Unity.XR.PXR.BoundaryType)typeof(Unity.XR.PXR.BoundaryType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.BoundaryTrackingNode @node = (Unity.XR.PXR.BoundaryTrackingNode)typeof(Unity.XR.PXR.BoundaryTrackingNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.TestNode(@node, @boundaryType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TestPoint_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.BoundaryType @boundaryType = (Unity.XR.PXR.BoundaryType)typeof(Unity.XR.PXR.BoundaryType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.XR.PXR.PxrVector3f @point = (Unity.XR.PXR.PxrVector3f)typeof(Unity.XR.PXR.PxrVector3f).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.TestPoint(@point, @boundaryType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGeometry_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.BoundaryType @boundaryType = (Unity.XR.PXR.BoundaryType)typeof(Unity.XR.PXR.BoundaryType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetGeometry(@boundaryType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDimensions_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.XR.PXR.BoundaryType @boundaryType = (Unity.XR.PXR.BoundaryType)typeof(Unity.XR.PXR.BoundaryType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetDimensions(@boundaryType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EnableSeeThroughManual_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            Unity.XR.PXR.PXR_Boundary.EnableSeeThroughManual(@value);

            return __ret;
        }

        static StackObject* GetDialogState_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Unity.XR.PXR.PXR_Boundary.GetDialogState();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.XR.PXR.PXR_Boundary();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
