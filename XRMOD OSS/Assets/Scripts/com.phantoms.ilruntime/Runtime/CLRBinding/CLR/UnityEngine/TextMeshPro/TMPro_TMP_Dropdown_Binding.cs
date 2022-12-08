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
    unsafe class TMPro_TMP_Dropdown_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(TMPro.TMP_Dropdown);
            // args = new Type[]{};
            // method = type.GetMethod("get_template", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_template_0);
            // args = new Type[]{typeof(UnityEngine.RectTransform)};
            // method = type.GetMethod("set_template", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_template_1);
            // args = new Type[]{};
            // method = type.GetMethod("get_captionText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_captionText_2);
            // args = new Type[]{typeof(TMPro.TMP_Text)};
            // method = type.GetMethod("set_captionText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_captionText_3);
            // args = new Type[]{};
            // method = type.GetMethod("get_captionImage", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_captionImage_4);
            // args = new Type[]{typeof(UnityEngine.UI.Image)};
            // method = type.GetMethod("set_captionImage", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_captionImage_5);
            // args = new Type[]{};
            // method = type.GetMethod("get_placeholder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_placeholder_6);
            // args = new Type[]{typeof(UnityEngine.UI.Graphic)};
            // method = type.GetMethod("set_placeholder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_placeholder_7);
            args = new Type[]{};
            method = type.GetMethod("get_itemText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_itemText_8);
            args = new Type[]{typeof(TMPro.TMP_Text)};
            method = type.GetMethod("set_itemText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_itemText_9);
            // args = new Type[]{};
            // method = type.GetMethod("get_itemImage", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_itemImage_10);
            // args = new Type[]{typeof(UnityEngine.UI.Image)};
            // method = type.GetMethod("set_itemImage", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_itemImage_11);
            args = new Type[]{};
            method = type.GetMethod("get_options", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_options_12);
            args = new Type[]{typeof(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>)};
            method = type.GetMethod("set_options", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_options_13);
            args = new Type[]{};
            method = type.GetMethod("get_onValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onValueChanged_14);
            args = new Type[]{typeof(TMPro.TMP_Dropdown.DropdownEvent)};
            method = type.GetMethod("set_onValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onValueChanged_15);
            args = new Type[]{};
            // method = type.GetMethod("get_alphaFadeSpeed", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_alphaFadeSpeed_16);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_alphaFadeSpeed", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_alphaFadeSpeed_17);
            args = new Type[]{};
            method = type.GetMethod("get_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_value_18);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_value_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetValueWithoutNotify", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetValueWithoutNotify_20);
            // args = new Type[]{};
            // method = type.GetMethod("get_IsExpanded", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_IsExpanded_21);
            args = new Type[]{};
            method = type.GetMethod("RefreshShownValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshShownValue_22);
            args = new Type[]{typeof(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>)};
            method = type.GetMethod("AddOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddOptions_23);
            args = new Type[]{typeof(System.Collections.Generic.List<System.String>)};
            method = type.GetMethod("AddOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddOptions_24);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Sprite>)};
            method = type.GetMethod("AddOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddOptions_25);
            args = new Type[]{};
            method = type.GetMethod("ClearOptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearOptions_26);
            args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            method = type.GetMethod("OnPointerClick", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnPointerClick_27);
            args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            method = type.GetMethod("OnSubmit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSubmit_28);
            args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            method = type.GetMethod("OnCancel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnCancel_29);
            args = new Type[]{};
            method = type.GetMethod("Show", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Show_30);
            args = new Type[]{};
            method = type.GetMethod("Hide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Hide_31);



            app.RegisterCLRCreateArrayInstance(type, s => new TMPro.TMP_Dropdown[s]);


        }


        // static StackObject* get_template_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.template;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_template_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.RectTransform @value = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.template = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_captionText_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.captionText;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_captionText_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text @value = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.captionText = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_captionImage_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.captionImage;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_captionImage_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.UI.Image @value = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.captionImage = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_placeholder_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.placeholder;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_placeholder_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.UI.Graphic @value = (UnityEngine.UI.Graphic)typeof(UnityEngine.UI.Graphic).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.placeholder = value;
        //
        //     return __ret;
        // }
        //
        static StackObject* get_itemText_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.itemText;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_itemText_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Text @value = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.itemText = value;
        
            return __ret;
        }
        //
        // static StackObject* get_itemImage_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.itemImage;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_itemImage_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.UI.Image @value = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.itemImage = value;
        //
        //     return __ret;
        // }
        //
        static StackObject* get_options_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.options;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_options_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> @value = (System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>)typeof(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.options = value;
        
            return __ret;
        }
        //
        static StackObject* get_onValueChanged_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onValueChanged;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_onValueChanged_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown.DropdownEvent @value = (TMPro.TMP_Dropdown.DropdownEvent)typeof(TMPro.TMP_Dropdown.DropdownEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onValueChanged = value;
        
            return __ret;
        }
        //
        // static StackObject* get_alphaFadeSpeed_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.alphaFadeSpeed;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_alphaFadeSpeed_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.alphaFadeSpeed = value;
        //
        //     return __ret;
        // }
        //
        static StackObject* get_value_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.value;
        
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }
        
        static StackObject* set_value_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.value = value;
        
            return __ret;
        }
        //
        static StackObject* SetValueWithoutNotify_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @input = ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetValueWithoutNotify(@input);
        
            return __ret;
        }
        //
        // static StackObject* get_IsExpanded_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.IsExpanded;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        static StackObject* RefreshShownValue_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.RefreshShownValue();
        
            return __ret;
        }
        //
        static StackObject* AddOptions_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> @options = (System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>)typeof(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.AddOptions(@options);
        
            return __ret;
        }
        //
        static StackObject* AddOptions_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.String> @options = (System.Collections.Generic.List<System.String>)typeof(System.Collections.Generic.List<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.AddOptions(@options);
        
            return __ret;
        }
        //
        static StackObject* AddOptions_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Sprite> @options = (System.Collections.Generic.List<UnityEngine.Sprite>)typeof(System.Collections.Generic.List<UnityEngine.Sprite>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.AddOptions(@options);
        
            return __ret;
        }
        //
        static StackObject* ClearOptions_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.ClearOptions();
        
            return __ret;
        }
        //
        static StackObject* OnPointerClick_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.OnPointerClick(@eventData);
        
            return __ret;
        }
        //
        static StackObject* OnSubmit_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.OnSubmit(@eventData);
        
            return __ret;
        }
        
        static StackObject* OnCancel_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.OnCancel(@eventData);
        
            return __ret;
        }
        
        static StackObject* Show_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.Show();
        
            return __ret;
        }
        
        static StackObject* Hide_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Dropdown instance_of_this_method = (TMPro.TMP_Dropdown)typeof(TMPro.TMP_Dropdown).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.Hide();
        
            return __ret;
        }





    }
}
