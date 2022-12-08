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
    unsafe class TMPro_TMP_InputField_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(TMPro.TMP_InputField);
            // args = new Type[]{};
            // method = type.GetMethod("get_shouldHideMobileInput", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_shouldHideMobileInput_0);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_shouldHideMobileInput", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_shouldHideMobileInput_1);
            // args = new Type[]{};
            // method = type.GetMethod("get_shouldHideSoftKeyboard", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_shouldHideSoftKeyboard_2);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_shouldHideSoftKeyboard", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_shouldHideSoftKeyboard_3);
            args = new Type[]{};
            method = type.GetMethod("get_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_text_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_text_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetTextWithoutNotify", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTextWithoutNotify_6);
            // args = new Type[]{};
            // method = type.GetMethod("get_isFocused", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isFocused_7);
            // args = new Type[]{};
            // method = type.GetMethod("get_caretBlinkRate", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_caretBlinkRate_8);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_caretBlinkRate", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_caretBlinkRate_9);
            // args = new Type[]{};
            // method = type.GetMethod("get_caretWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_caretWidth_10);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_caretWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_caretWidth_11);
            // args = new Type[]{};
            // method = type.GetMethod("get_textViewport", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textViewport_12);
            // args = new Type[]{typeof(UnityEngine.RectTransform)};
            // method = type.GetMethod("set_textViewport", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_textViewport_13);
            // args = new Type[]{};
            // method = type.GetMethod("get_textComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textComponent_14);
            // args = new Type[]{typeof(TMPro.TMP_Text)};
            // method = type.GetMethod("set_textComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_textComponent_15);
            // args = new Type[]{};
            // method = type.GetMethod("get_placeholder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_placeholder_16);
            // args = new Type[]{typeof(UnityEngine.UI.Graphic)};
            // method = type.GetMethod("set_placeholder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_placeholder_17);
            // args = new Type[]{};
            // method = type.GetMethod("get_verticalScrollbar", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_verticalScrollbar_18);
            // args = new Type[]{typeof(UnityEngine.UI.Scrollbar)};
            // method = type.GetMethod("set_verticalScrollbar", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_verticalScrollbar_19);
            // args = new Type[]{};
            // method = type.GetMethod("get_scrollSensitivity", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_scrollSensitivity_20);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_scrollSensitivity", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_scrollSensitivity_21);
            // args = new Type[]{};
            // method = type.GetMethod("get_caretColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_caretColor_22);
            // args = new Type[]{typeof(UnityEngine.Color)};
            // method = type.GetMethod("set_caretColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_caretColor_23);
            // args = new Type[]{};
            // method = type.GetMethod("get_customCaretColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_customCaretColor_24);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_customCaretColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_customCaretColor_25);
            // args = new Type[]{};
            // method = type.GetMethod("get_selectionColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_selectionColor_26);
            // args = new Type[]{typeof(UnityEngine.Color)};
            // method = type.GetMethod("set_selectionColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_selectionColor_27);
            args = new Type[]{};
            method = type.GetMethod("get_onEndEdit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onEndEdit_28);
            args = new Type[]{typeof(TMPro.TMP_InputField.SubmitEvent)};
            method = type.GetMethod("set_onEndEdit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onEndEdit_29);
            args = new Type[]{};
            method = type.GetMethod("get_onSubmit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onSubmit_30);
            args = new Type[]{typeof(TMPro.TMP_InputField.SubmitEvent)};
            method = type.GetMethod("set_onSubmit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onSubmit_31);
            args = new Type[]{};
            method = type.GetMethod("get_onSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onSelect_32);
            args = new Type[]{typeof(TMPro.TMP_InputField.SelectionEvent)};
            method = type.GetMethod("set_onSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onSelect_33);
            args = new Type[]{};
            method = type.GetMethod("get_onDeselect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onDeselect_34);
            args = new Type[]{typeof(TMPro.TMP_InputField.SelectionEvent)};
            method = type.GetMethod("set_onDeselect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onDeselect_35);
            args = new Type[]{};
            method = type.GetMethod("get_onTextSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onTextSelection_36);
            args = new Type[]{typeof(TMPro.TMP_InputField.TextSelectionEvent)};
            method = type.GetMethod("set_onTextSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onTextSelection_37);
            args = new Type[]{};
            method = type.GetMethod("get_onEndTextSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onEndTextSelection_38);
            args = new Type[]{typeof(TMPro.TMP_InputField.TextSelectionEvent)};
            method = type.GetMethod("set_onEndTextSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onEndTextSelection_39);
            args = new Type[]{};
            method = type.GetMethod("get_onValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onValueChanged_40);
            args = new Type[]{typeof(TMPro.TMP_InputField.OnChangeEvent)};
            method = type.GetMethod("set_onValueChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onValueChanged_41);
            // args = new Type[]{};
            // method = type.GetMethod("get_onTouchScreenKeyboardStatusChanged", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_onTouchScreenKeyboardStatusChanged_42);
            // args = new Type[]{typeof(TMPro.TMP_InputField.TouchScreenKeyboardEvent)};
            // method = type.GetMethod("set_onTouchScreenKeyboardStatusChanged", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_onTouchScreenKeyboardStatusChanged_43);
            // args = new Type[]{};
            // method = type.GetMethod("get_onValidateInput", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_onValidateInput_44);
            // args = new Type[]{typeof(TMPro.TMP_InputField.OnValidateInput)};
            // method = type.GetMethod("set_onValidateInput", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_onValidateInput_45);
            // args = new Type[]{};
            // method = type.GetMethod("get_characterLimit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_characterLimit_46);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_characterLimit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_characterLimit_47);
            // args = new Type[]{};
            // method = type.GetMethod("get_pointSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_pointSize_48);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_pointSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_pointSize_49);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontAsset_50);
            // args = new Type[]{typeof(TMPro.TMP_FontAsset)};
            // method = type.GetMethod("set_fontAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontAsset_51);
            // args = new Type[]{};
            // method = type.GetMethod("get_onFocusSelectAll", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_onFocusSelectAll_52);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_onFocusSelectAll", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_onFocusSelectAll_53);
            // args = new Type[]{};
            // method = type.GetMethod("get_resetOnDeActivation", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_resetOnDeActivation_54);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_resetOnDeActivation", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_resetOnDeActivation_55);
            // args = new Type[]{};
            // method = type.GetMethod("get_restoreOriginalTextOnEscape", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_restoreOriginalTextOnEscape_56);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_restoreOriginalTextOnEscape", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_restoreOriginalTextOnEscape_57);
            // args = new Type[]{};
            // method = type.GetMethod("get_isRichTextEditingAllowed", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isRichTextEditingAllowed_58);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isRichTextEditingAllowed", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isRichTextEditingAllowed_59);
            // args = new Type[]{};
            // method = type.GetMethod("get_contentType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_contentType_60);
            // args = new Type[]{typeof(TMPro.TMP_InputField.ContentType)};
            // method = type.GetMethod("set_contentType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_contentType_61);
            // args = new Type[]{};
            // method = type.GetMethod("get_lineType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_lineType_62);
            // args = new Type[]{typeof(TMPro.TMP_InputField.LineType)};
            // method = type.GetMethod("set_lineType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_lineType_63);
            // args = new Type[]{};
            // method = type.GetMethod("get_lineLimit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_lineLimit_64);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_lineLimit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_lineLimit_65);
            // args = new Type[]{};
            // method = type.GetMethod("get_inputType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_inputType_66);
            // args = new Type[]{typeof(TMPro.TMP_InputField.InputType)};
            // method = type.GetMethod("set_inputType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_inputType_67);
            // args = new Type[]{};
            // method = type.GetMethod("get_keyboardType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_keyboardType_68);
            // args = new Type[]{typeof(UnityEngine.TouchScreenKeyboardType)};
            // method = type.GetMethod("set_keyboardType", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_keyboardType_69);
            // args = new Type[]{};
            // method = type.GetMethod("get_characterValidation", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_characterValidation_70);
            // args = new Type[]{typeof(TMPro.TMP_InputField.CharacterValidation)};
            // method = type.GetMethod("set_characterValidation", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_characterValidation_71);
            // args = new Type[]{};
            // method = type.GetMethod("get_inputValidator", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_inputValidator_72);
            // args = new Type[]{typeof(TMPro.TMP_InputValidator)};
            // method = type.GetMethod("set_inputValidator", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_inputValidator_73);
            // args = new Type[]{};
            // method = type.GetMethod("get_readOnly", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_readOnly_74);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_readOnly", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_readOnly_75);
            // args = new Type[]{};
            // method = type.GetMethod("get_richText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_richText_76);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_richText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_richText_77);
            // args = new Type[]{};
            // method = type.GetMethod("get_multiLine", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_multiLine_78);
            // args = new Type[]{};
            // method = type.GetMethod("get_asteriskChar", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_asteriskChar_79);
            // args = new Type[]{typeof(System.Char)};
            // method = type.GetMethod("set_asteriskChar", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_asteriskChar_80);
            // args = new Type[]{};
            // method = type.GetMethod("get_wasCanceled", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_wasCanceled_81);
            // args = new Type[]{};
            // method = type.GetMethod("get_caretPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_caretPosition_82);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_caretPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_caretPosition_83);
            // args = new Type[]{};
            // method = type.GetMethod("get_selectionAnchorPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_selectionAnchorPosition_84);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_selectionAnchorPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_selectionAnchorPosition_85);
            // args = new Type[]{};
            // method = type.GetMethod("get_selectionFocusPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_selectionFocusPosition_86);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_selectionFocusPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_selectionFocusPosition_87);
            // args = new Type[]{};
            // method = type.GetMethod("get_stringPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_stringPosition_88);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_stringPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_stringPosition_89);
            // args = new Type[]{};
            // method = type.GetMethod("get_selectionStringAnchorPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_selectionStringAnchorPosition_90);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_selectionStringAnchorPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_selectionStringAnchorPosition_91);
            // args = new Type[]{};
            // method = type.GetMethod("get_selectionStringFocusPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_selectionStringFocusPosition_92);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_selectionStringFocusPosition", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_selectionStringFocusPosition_93);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("MoveTextEnd", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, MoveTextEnd_94);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("MoveTextStart", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, MoveTextStart_95);
            // args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            // method = type.GetMethod("MoveToEndOfLine", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, MoveToEndOfLine_96);
            // args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            // method = type.GetMethod("MoveToStartOfLine", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, MoveToStartOfLine_97);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnBeginDrag", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnBeginDrag_98);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnDrag", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnDrag_99);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnEndDrag", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnEndDrag_100);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnPointerDown", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnPointerDown_101);
            // args = new Type[]{typeof(UnityEngine.Event)};
            // method = type.GetMethod("ProcessEvent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ProcessEvent_102);
            // args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            // method = type.GetMethod("OnUpdateSelected", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnUpdateSelected_103);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnScroll", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnScroll_104);
            // args = new Type[]{};
            // method = type.GetMethod("ForceLabelUpdate", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ForceLabelUpdate_105);
            // args = new Type[]{typeof(UnityEngine.UI.CanvasUpdate)};
            // method = type.GetMethod("Rebuild", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, Rebuild_106);
            // args = new Type[]{};
            // method = type.GetMethod("LayoutComplete", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, LayoutComplete_107);
            // args = new Type[]{};
            // method = type.GetMethod("GraphicUpdateComplete", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GraphicUpdateComplete_108);
            // args = new Type[]{};
            // method = type.GetMethod("ActivateInputField", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ActivateInputField_109);
            // args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            // method = type.GetMethod("OnSelect", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnSelect_110);
            // args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            // method = type.GetMethod("OnPointerClick", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnPointerClick_111);
            // args = new Type[]{};
            // method = type.GetMethod("OnControlClick", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnControlClick_112);
            // args = new Type[]{};
            // method = type.GetMethod("ReleaseSelection", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ReleaseSelection_113);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("DeactivateInputField", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, DeactivateInputField_114);
            // args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            // method = type.GetMethod("OnDeselect", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnDeselect_115);
            // args = new Type[]{typeof(UnityEngine.EventSystems.BaseEventData)};
            // method = type.GetMethod("OnSubmit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, OnSubmit_116);
            // args = new Type[]{};
            // method = type.GetMethod("CalculateLayoutInputHorizontal", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CalculateLayoutInputHorizontal_117);
            // args = new Type[]{};
            // method = type.GetMethod("CalculateLayoutInputVertical", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CalculateLayoutInputVertical_118);
            // args = new Type[]{};
            // method = type.GetMethod("get_minWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_minWidth_119);
            // args = new Type[]{};
            // method = type.GetMethod("get_preferredWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_preferredWidth_120);
            // args = new Type[]{};
            // method = type.GetMethod("get_flexibleWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_flexibleWidth_121);
            // args = new Type[]{};
            // method = type.GetMethod("get_minHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_minHeight_122);
            // args = new Type[]{};
            // method = type.GetMethod("get_preferredHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_preferredHeight_123);
            // args = new Type[]{};
            // method = type.GetMethod("get_flexibleHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_flexibleHeight_124);
            // args = new Type[]{};
            // method = type.GetMethod("get_layoutPriority", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_layoutPriority_125);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("SetGlobalPointSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetGlobalPointSize_126);
            // args = new Type[]{typeof(TMPro.TMP_FontAsset)};
            // method = type.GetMethod("SetGlobalFontAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetGlobalFontAsset_127);



            app.RegisterCLRCreateArrayInstance(type, s => new TMPro.TMP_InputField[s]);


        }


        // static StackObject* get_shouldHideMobileInput_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.shouldHideMobileInput;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_shouldHideMobileInput_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.shouldHideMobileInput = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_shouldHideSoftKeyboard_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.shouldHideSoftKeyboard;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_shouldHideSoftKeyboard_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.shouldHideSoftKeyboard = value;
        //
        //     return __ret;
        // }

        static StackObject* get_text_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.text;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_text_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.text = value;

            return __ret;
        }

        static StackObject* SetTextWithoutNotify_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @input = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTextWithoutNotify(@input);

            return __ret;
        }

        // static StackObject* get_isFocused_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isFocused;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_caretBlinkRate_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.caretBlinkRate;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_caretBlinkRate_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.caretBlinkRate = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_caretWidth_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.caretWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_caretWidth_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.caretWidth = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_textViewport_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textViewport;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_textViewport_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.textViewport = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_textComponent_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textComponent;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_textComponent_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.textComponent = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_placeholder_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
        // static StackObject* set_placeholder_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.placeholder = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_verticalScrollbar_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.verticalScrollbar;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_verticalScrollbar_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.UI.Scrollbar @value = (UnityEngine.UI.Scrollbar)typeof(UnityEngine.UI.Scrollbar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.verticalScrollbar = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_scrollSensitivity_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.scrollSensitivity;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_scrollSensitivity_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.scrollSensitivity = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_caretColor_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.caretColor;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_caretColor_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.caretColor = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_customCaretColor_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.customCaretColor;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_customCaretColor_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.customCaretColor = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_selectionColor_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.selectionColor;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_selectionColor_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.selectionColor = value;
        //
        //     return __ret;
        // }
        //
        static StackObject* get_onEndEdit_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onEndEdit;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        //
        static StackObject* set_onEndEdit_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.SubmitEvent @value = (TMPro.TMP_InputField.SubmitEvent)typeof(TMPro.TMP_InputField.SubmitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onEndEdit = value;
        
            return __ret;
        }
        //
        static StackObject* get_onSubmit_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onSubmit;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_onSubmit_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.SubmitEvent @value = (TMPro.TMP_InputField.SubmitEvent)typeof(TMPro.TMP_InputField.SubmitEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onSubmit = value;
        
            return __ret;
        }
        
        static StackObject* get_onSelect_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onSelect;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_onSelect_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.SelectionEvent @value = (TMPro.TMP_InputField.SelectionEvent)typeof(TMPro.TMP_InputField.SelectionEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onSelect = value;
        
            return __ret;
        }
        
        static StackObject* get_onDeselect_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onDeselect;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_onDeselect_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.SelectionEvent @value = (TMPro.TMP_InputField.SelectionEvent)typeof(TMPro.TMP_InputField.SelectionEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onDeselect = value;
        
            return __ret;
        }
        //
        static StackObject* get_onTextSelection_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onTextSelection;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* set_onTextSelection_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.TextSelectionEvent @value = (TMPro.TMP_InputField.TextSelectionEvent)typeof(TMPro.TMP_InputField.TextSelectionEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onTextSelection = value;
        
            return __ret;
        }
        //
        static StackObject* get_onEndTextSelection_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onEndTextSelection;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        //
        static StackObject* set_onEndTextSelection_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.TextSelectionEvent @value = (TMPro.TMP_InputField.TextSelectionEvent)typeof(TMPro.TMP_InputField.TextSelectionEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onEndTextSelection = value;
        
            return __ret;
        }
        //
        static StackObject* get_onValueChanged_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            var result_of_this_method = instance_of_this_method.onValueChanged;
        
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        //
        static StackObject* set_onValueChanged_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_InputField.OnChangeEvent @value = (TMPro.TMP_InputField.OnChangeEvent)typeof(TMPro.TMP_InputField.OnChangeEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.onValueChanged = value;
        
            return __ret;
        }
        //
        // static StackObject* get_onTouchScreenKeyboardStatusChanged_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.onTouchScreenKeyboardStatusChanged;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_onTouchScreenKeyboardStatusChanged_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.TouchScreenKeyboardEvent @value = (TMPro.TMP_InputField.TouchScreenKeyboardEvent)typeof(TMPro.TMP_InputField.TouchScreenKeyboardEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.onTouchScreenKeyboardStatusChanged = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_onValidateInput_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.onValidateInput;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_onValidateInput_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.OnValidateInput @value = (TMPro.TMP_InputField.OnValidateInput)typeof(TMPro.TMP_InputField.OnValidateInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.onValidateInput = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_characterLimit_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.characterLimit;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_characterLimit_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.characterLimit = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_pointSize_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.pointSize;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_pointSize_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.pointSize = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontAsset_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontAsset;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontAsset_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_FontAsset @value = (TMPro.TMP_FontAsset)typeof(TMPro.TMP_FontAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontAsset = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_onFocusSelectAll_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.onFocusSelectAll;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_onFocusSelectAll_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.onFocusSelectAll = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_resetOnDeActivation_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.resetOnDeActivation;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_resetOnDeActivation_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.resetOnDeActivation = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_restoreOriginalTextOnEscape_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.restoreOriginalTextOnEscape;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_restoreOriginalTextOnEscape_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.restoreOriginalTextOnEscape = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isRichTextEditingAllowed_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isRichTextEditingAllowed;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isRichTextEditingAllowed_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isRichTextEditingAllowed = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_contentType_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.contentType;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_contentType_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.ContentType @value = (TMPro.TMP_InputField.ContentType)typeof(TMPro.TMP_InputField.ContentType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.contentType = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_lineType_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.lineType;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_lineType_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.LineType @value = (TMPro.TMP_InputField.LineType)typeof(TMPro.TMP_InputField.LineType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.lineType = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_lineLimit_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.lineLimit;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_lineLimit_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.lineLimit = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_inputType_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.inputType;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_inputType_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.InputType @value = (TMPro.TMP_InputField.InputType)typeof(TMPro.TMP_InputField.InputType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.inputType = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_keyboardType_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.keyboardType;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_keyboardType_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.TouchScreenKeyboardType @value = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.keyboardType = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_characterValidation_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.characterValidation;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_characterValidation_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField.CharacterValidation @value = (TMPro.TMP_InputField.CharacterValidation)typeof(TMPro.TMP_InputField.CharacterValidation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.characterValidation = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_inputValidator_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.inputValidator;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_inputValidator_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputValidator @value = (TMPro.TMP_InputValidator)typeof(TMPro.TMP_InputValidator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.inputValidator = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_readOnly_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.readOnly;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_readOnly_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.readOnly = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_richText_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.richText;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_richText_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.richText = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_multiLine_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.multiLine;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_asteriskChar_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.asteriskChar;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = (int)result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_asteriskChar_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Char @value = (char)ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.asteriskChar = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_wasCanceled_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.wasCanceled;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_caretPosition_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.caretPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_caretPosition_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.caretPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_selectionAnchorPosition_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.selectionAnchorPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_selectionAnchorPosition_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.selectionAnchorPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_selectionFocusPosition_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.selectionFocusPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_selectionFocusPosition_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.selectionFocusPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_stringPosition_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.stringPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_stringPosition_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.stringPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_selectionStringAnchorPosition_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.selectionStringAnchorPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_selectionStringAnchorPosition_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.selectionStringAnchorPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_selectionStringFocusPosition_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.selectionStringFocusPosition;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_selectionStringFocusPosition_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.selectionStringFocusPosition = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* MoveTextEnd_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @shift = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.MoveTextEnd(@shift);
        //
        //     return __ret;
        // }
        //
        // static StackObject* MoveTextStart_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @shift = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.MoveTextStart(@shift);
        //
        //     return __ret;
        // }
        //
        // static StackObject* MoveToEndOfLine_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @ctrl = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Boolean @shift = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.MoveToEndOfLine(@shift, @ctrl);
        //
        //     return __ret;
        // }
        //
        // static StackObject* MoveToStartOfLine_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @ctrl = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Boolean @shift = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.MoveToStartOfLine(@shift, @ctrl);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnBeginDrag_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnBeginDrag(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnDrag_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnDrag(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnEndDrag_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnEndDrag(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnPointerDown_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPointerDown(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* ProcessEvent_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Event @e = (UnityEngine.Event)typeof(UnityEngine.Event).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ProcessEvent(@e);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnUpdateSelected_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnUpdateSelected(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnScroll_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnScroll(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* ForceLabelUpdate_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ForceLabelUpdate();
        //
        //     return __ret;
        // }
        //
        // static StackObject* Rebuild_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.Rebuild(@update);
        //
        //     return __ret;
        // }
        //
        // static StackObject* LayoutComplete_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.LayoutComplete();
        //
        //     return __ret;
        // }
        //
        // static StackObject* GraphicUpdateComplete_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.GraphicUpdateComplete();
        //
        //     return __ret;
        // }
        //
        // static StackObject* ActivateInputField_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ActivateInputField();
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnSelect_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnSelect(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnPointerClick_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPointerClick(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnControlClick_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnControlClick();
        //
        //     return __ret;
        // }
        //
        // static StackObject* ReleaseSelection_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ReleaseSelection();
        //
        //     return __ret;
        // }
        //
        // static StackObject* DeactivateInputField_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @clearSelection = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.DeactivateInputField(@clearSelection);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnDeselect_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnDeselect(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* OnSubmit_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.EventSystems.BaseEventData @eventData = (UnityEngine.EventSystems.BaseEventData)typeof(UnityEngine.EventSystems.BaseEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnSubmit(@eventData);
        //
        //     return __ret;
        // }
        //
        // static StackObject* CalculateLayoutInputHorizontal_117(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CalculateLayoutInputHorizontal();
        //
        //     return __ret;
        // }
        //
        // static StackObject* CalculateLayoutInputVertical_118(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CalculateLayoutInputVertical();
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_minWidth_119(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.minWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_preferredWidth_120(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.preferredWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_flexibleWidth_121(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.flexibleWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_minHeight_122(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.minHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_preferredHeight_123(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.preferredHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_flexibleHeight_124(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.flexibleHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_layoutPriority_125(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.layoutPriority;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* SetGlobalPointSize_126(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @pointSize = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetGlobalPointSize(@pointSize);
        //
        //     return __ret;
        // }
        //
        // static StackObject* SetGlobalFontAsset_127(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_FontAsset @fontAsset = (TMPro.TMP_FontAsset)typeof(TMPro.TMP_FontAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_InputField instance_of_this_method = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetGlobalFontAsset(@fontAsset);
        //
        //     return __ret;
        // }
        //




    }
}
