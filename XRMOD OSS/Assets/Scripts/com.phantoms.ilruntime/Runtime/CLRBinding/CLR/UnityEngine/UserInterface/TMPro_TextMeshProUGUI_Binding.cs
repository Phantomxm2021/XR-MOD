// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
   unsafe class TMPro_TextMeshProUGUI_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(TMPro.TextMeshProUGUI);
            args = new Type[]{};
            // method = type.GetMethod("ComputeMarginSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ComputeMarginSize_0);
            // args = new Type[]{};
            // method = type.GetMethod("get_materialForRendering", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_materialForRendering_1);
            // args = new Type[]{};
            // method = type.GetMethod("get_autoSizeTextContainer", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_autoSizeTextContainer_2);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_autoSizeTextContainer", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_autoSizeTextContainer_3);
            // args = new Type[]{};
            // method = type.GetMethod("get_mesh", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_mesh_4);
            // args = new Type[]{};
            // method = type.GetMethod("get_canvasRenderer", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_canvasRenderer_5);
            // args = new Type[]{};
            // method = type.GetMethod("CalculateLayoutInputHorizontal", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CalculateLayoutInputHorizontal_6);
            // args = new Type[]{};
            // method = type.GetMethod("CalculateLayoutInputVertical", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CalculateLayoutInputVertical_7);
            // args = new Type[]{};
            // method = type.GetMethod("SetVerticesDirty", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetVerticesDirty_8);
            // args = new Type[]{};
            // method = type.GetMethod("SetLayoutDirty", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetLayoutDirty_9);
            // args = new Type[]{};
            // method = type.GetMethod("SetMaterialDirty", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetMaterialDirty_10);
            // args = new Type[]{};
            // method = type.GetMethod("SetAllDirty", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetAllDirty_11);
            // args = new Type[]{typeof(UnityEngine.UI.CanvasUpdate)};
            // method = type.GetMethod("Rebuild", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, Rebuild_12);
            // args = new Type[]{typeof(UnityEngine.Material)};
            // method = type.GetMethod("GetModifiedMaterial", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetModifiedMaterial_13);
            // args = new Type[]{};
            // method = type.GetMethod("get_maskOffset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maskOffset_14);
            // args = new Type[]{typeof(UnityEngine.Vector4)};
            // method = type.GetMethod("set_maskOffset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_maskOffset_15);
            // args = new Type[]{};
            // method = type.GetMethod("RecalculateClipping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, RecalculateClipping_16);
            // args = new Type[]{typeof(UnityEngine.Rect), typeof(System.Boolean)};
            // method = type.GetMethod("Cull", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, Cull_17);
            // args = new Type[]{};
            // method = type.GetMethod("UpdateMeshPadding", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateMeshPadding_18);
            // args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            // method = type.GetMethod("ForceMeshUpdate", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ForceMeshUpdate_19);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetTextInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTextInfo_20);
            args = new Type[]{};
            // method = type.GetMethod("ClearMesh", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ClearMesh_21);
            // args = new Type[]{typeof(System.Action<TMPro.TMP_TextInfo>)};
            // method = type.GetMethod("add_OnPreRenderText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, add_OnPreRenderText_22);
            // args = new Type[]{typeof(System.Action<TMPro.TMP_TextInfo>)};
            // method = type.GetMethod("remove_OnPreRenderText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, remove_OnPreRenderText_23);
            // args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32)};
            // method = type.GetMethod("UpdateGeometry", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateGeometry_24);
            // args = new Type[]{typeof(TMPro.TMP_VertexDataUpdateFlags)};
            // method = type.GetMethod("UpdateVertexData", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateVertexData_25);
            // args = new Type[]{};
            // method = type.GetMethod("UpdateVertexData", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateVertexData_26);
            // args = new Type[]{};
            // method = type.GetMethod("UpdateFontAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateFontAsset_27);



            app.RegisterCLRCreateDefaultInstance(type, () => new TMPro.TextMeshProUGUI());
            app.RegisterCLRCreateArrayInstance(type, s => new TMPro.TextMeshProUGUI[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        // static StackObject* ComputeMarginSize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ComputeMarginSize();
        //
        //     return __ret;
        // }

        static StackObject* get_materialForRendering_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materialForRendering;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        // static StackObject* get_autoSizeTextContainer_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.autoSizeTextContainer;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }

        // static StackObject* set_autoSizeTextContainer_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.autoSizeTextContainer = value;
        //
        //     return __ret;
        // }

        // static StackObject* get_mesh_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.mesh;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* get_canvasRenderer_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.canvasRenderer;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* CalculateLayoutInputHorizontal_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CalculateLayoutInputHorizontal();
        //
        //     return __ret;
        // }

        // static StackObject* CalculateLayoutInputVertical_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CalculateLayoutInputVertical();
        //
        //     return __ret;
        // }

        // static StackObject* SetVerticesDirty_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetVerticesDirty();
        //
        //     return __ret;
        // }

        // static StackObject* SetLayoutDirty_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetLayoutDirty();
        //
        //     return __ret;
        // }

        // static StackObject* SetMaterialDirty_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetMaterialDirty();
        //
        //     return __ret;
        // }

        // static StackObject* SetAllDirty_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetAllDirty();
        //
        //     return __ret;
        // }

        // static StackObject* Rebuild_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.UI.CanvasUpdate @update = (UnityEngine.UI.CanvasUpdate)typeof(UnityEngine.UI.CanvasUpdate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.Rebuild(@update);
        //
        //     return __ret;
        // }

        // static StackObject* GetModifiedMaterial_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Material @baseMaterial = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetModifiedMaterial(@baseMaterial);
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* get_maskOffset_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maskOffset;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* set_maskOffset_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector4 @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.maskOffset = value;
        //
        //     return __ret;
        // }

        // static StackObject* RecalculateClipping_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.RecalculateClipping();
        //
        //     return __ret;
        // }

        // static StackObject* Cull_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @validRect = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Rect @clipRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.Cull(@clipRect, @validRect);
        //
        //     return __ret;
        // }

        // static StackObject* UpdateMeshPadding_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateMeshPadding();
        //
        //     return __ret;
        // }

        // static StackObject* ForceMeshUpdate_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @forceTextReparsing = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Boolean @ignoreActiveState = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ForceMeshUpdate(@ignoreActiveState, @forceTextReparsing);
        //
        //     return __ret;
        // }

        static StackObject* GetTextInfo_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTextInfo(@text);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        // static StackObject* ClearMesh_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ClearMesh();
        //
        //     return __ret;
        // }

        // static StackObject* add_OnPreRenderText_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Action<TMPro.TMP_TextInfo> @value = (System.Action<TMPro.TMP_TextInfo>)typeof(System.Action<TMPro.TMP_TextInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPreRenderText += value;
        //
        //     return __ret;
        // }

        // static StackObject* remove_OnPreRenderText_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Action<TMPro.TMP_TextInfo> @value = (System.Action<TMPro.TMP_TextInfo>)typeof(System.Action<TMPro.TMP_TextInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPreRenderText -= value;
        //
        //     return __ret;
        // }

        // static StackObject* UpdateGeometry_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @index = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateGeometry(@mesh, @index);
        //
        //     return __ret;
        // }

        // static StackObject* UpdateVertexData_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_VertexDataUpdateFlags @flags = (TMPro.TMP_VertexDataUpdateFlags)typeof(TMPro.TMP_VertexDataUpdateFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateVertexData(@flags);
        //
        //     return __ret;
        // }

        // static StackObject* UpdateVertexData_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateVertexData();
        //
        //     return __ret;
        // }

        // static StackObject* UpdateFontAsset_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextMeshProUGUI instance_of_this_method = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateFontAsset();
        //
        //     return __ret;
        // }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new TMPro.TextMeshProUGUI();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}