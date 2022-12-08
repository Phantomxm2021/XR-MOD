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
    unsafe class TMPro_TMP_Text_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(TMPro.TMP_Text);
            args = new Type[]{};
            method = type.GetMethod("get_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_text_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_text_1);
            // args = new Type[]{};
            // method = type.GetMethod("get_textPreprocessor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textPreprocessor_2);
            // args = new Type[]{typeof(TMPro.ITextPreprocessor)};
            // method = type.GetMethod("set_textPreprocessor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_textPreprocessor_3);
            // args = new Type[]{};
            // method = type.GetMethod("get_isRightToLeftText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isRightToLeftText_4);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isRightToLeftText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isRightToLeftText_5);
            // args = new Type[]{};
            // method = type.GetMethod("get_font", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_font_6);
            // args = new Type[]{typeof(TMPro.TMP_FontAsset)};
            // method = type.GetMethod("set_font", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_font_7);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontSharedMaterial", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontSharedMaterial_8);
            // args = new Type[]{typeof(UnityEngine.Material)};
            // method = type.GetMethod("set_fontSharedMaterial", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontSharedMaterial_9);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontSharedMaterials", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontSharedMaterials_10);
            // args = new Type[]{typeof(UnityEngine.Material[])};
            // method = type.GetMethod("set_fontSharedMaterials", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontSharedMaterials_11);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontMaterial", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontMaterial_12);
            // args = new Type[]{typeof(UnityEngine.Material)};
            // method = type.GetMethod("set_fontMaterial", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontMaterial_13);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontMaterials", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontMaterials_14);
            // args = new Type[]{typeof(UnityEngine.Material[])};
            // method = type.GetMethod("set_fontMaterials", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontMaterials_15);
            // args = new Type[]{};
            // method = type.GetMethod("get_color", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_color_16);
            // args = new Type[]{typeof(UnityEngine.Color)};
            // method = type.GetMethod("set_color", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_color_17);
            // args = new Type[]{};
            // method = type.GetMethod("get_alpha", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_alpha_18);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_alpha", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_alpha_19);
            // args = new Type[]{};
            // method = type.GetMethod("get_enableVertexGradient", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_enableVertexGradient_20);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_enableVertexGradient", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_enableVertexGradient_21);
            // args = new Type[]{};
            // method = type.GetMethod("get_colorGradient", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_colorGradient_22);
            // args = new Type[]{typeof(TMPro.VertexGradient)};
            // method = type.GetMethod("set_colorGradient", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_colorGradient_23);
            // args = new Type[]{};
            // method = type.GetMethod("get_colorGradientPreset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_colorGradientPreset_24);
            // args = new Type[]{typeof(TMPro.TMP_ColorGradient)};
            // method = type.GetMethod("set_colorGradientPreset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_colorGradientPreset_25);
            // args = new Type[]{};
            // method = type.GetMethod("get_spriteAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_spriteAsset_26);
            // args = new Type[]{typeof(TMPro.TMP_SpriteAsset)};
            // method = type.GetMethod("set_spriteAsset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_spriteAsset_27);
            // args = new Type[]{};
            // method = type.GetMethod("get_tintAllSprites", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_tintAllSprites_28);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_tintAllSprites", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_tintAllSprites_29);
            // args = new Type[]{};
            // method = type.GetMethod("get_styleSheet", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_styleSheet_30);
            // args = new Type[]{typeof(TMPro.TMP_StyleSheet)};
            // method = type.GetMethod("set_styleSheet", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_styleSheet_31);
            // args = new Type[]{};
            // method = type.GetMethod("get_textStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textStyle_32);
            // args = new Type[]{typeof(TMPro.TMP_Style)};
            // method = type.GetMethod("set_textStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_textStyle_33);
            // args = new Type[]{};
            // method = type.GetMethod("get_overrideColorTags", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_overrideColorTags_34);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_overrideColorTags", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_overrideColorTags_35);
            // args = new Type[]{};
            // method = type.GetMethod("get_faceColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_faceColor_36);
            // args = new Type[]{typeof(UnityEngine.Color32)};
            // method = type.GetMethod("set_faceColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_faceColor_37);
            // args = new Type[]{};
            // method = type.GetMethod("get_outlineColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_outlineColor_38);
            // args = new Type[]{typeof(UnityEngine.Color32)};
            // method = type.GetMethod("set_outlineColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_outlineColor_39);
            // args = new Type[]{};
            // method = type.GetMethod("get_outlineWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_outlineWidth_40);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_outlineWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_outlineWidth_41);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontSize_42);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_fontSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontSize_43);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontWeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontWeight_44);
            // args = new Type[]{typeof(TMPro.FontWeight)};
            // method = type.GetMethod("set_fontWeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontWeight_45);
            // args = new Type[]{};
            // method = type.GetMethod("get_pixelsPerUnit", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_pixelsPerUnit_46);
            // args = new Type[]{};
            // method = type.GetMethod("get_enableAutoSizing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_enableAutoSizing_47);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_enableAutoSizing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_enableAutoSizing_48);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontSizeMin", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontSizeMin_49);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_fontSizeMin", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontSizeMin_50);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontSizeMax", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontSizeMax_51);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_fontSizeMax", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontSizeMax_52);
            // args = new Type[]{};
            // method = type.GetMethod("get_fontStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_fontStyle_53);
            // args = new Type[]{typeof(TMPro.FontStyles)};
            // method = type.GetMethod("set_fontStyle", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_fontStyle_54);
            // args = new Type[]{};
            // method = type.GetMethod("get_isUsingBold", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isUsingBold_55);
            // args = new Type[]{};
            // method = type.GetMethod("get_horizontalAlignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_horizontalAlignment_56);
            // args = new Type[]{typeof(TMPro.HorizontalAlignmentOptions)};
            // method = type.GetMethod("set_horizontalAlignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_horizontalAlignment_57);
            // args = new Type[]{};
            // method = type.GetMethod("get_verticalAlignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_verticalAlignment_58);
            // args = new Type[]{typeof(TMPro.VerticalAlignmentOptions)};
            // method = type.GetMethod("set_verticalAlignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_verticalAlignment_59);
            // args = new Type[]{};
            // method = type.GetMethod("get_alignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_alignment_60);
            // args = new Type[]{typeof(TMPro.TextAlignmentOptions)};
            // method = type.GetMethod("set_alignment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_alignment_61);
            // args = new Type[]{};
            // method = type.GetMethod("get_characterSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_characterSpacing_62);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_characterSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_characterSpacing_63);
            // args = new Type[]{};
            // method = type.GetMethod("get_wordSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_wordSpacing_64);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_wordSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_wordSpacing_65);
            // args = new Type[]{};
            // method = type.GetMethod("get_lineSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_lineSpacing_66);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_lineSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_lineSpacing_67);
            // args = new Type[]{};
            // method = type.GetMethod("get_lineSpacingAdjustment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_lineSpacingAdjustment_68);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_lineSpacingAdjustment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_lineSpacingAdjustment_69);
            // args = new Type[]{};
            // method = type.GetMethod("get_paragraphSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_paragraphSpacing_70);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_paragraphSpacing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_paragraphSpacing_71);
            // args = new Type[]{};
            // method = type.GetMethod("get_characterWidthAdjustment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_characterWidthAdjustment_72);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_characterWidthAdjustment", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_characterWidthAdjustment_73);
            // args = new Type[]{};
            // method = type.GetMethod("get_enableWordWrapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_enableWordWrapping_74);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_enableWordWrapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_enableWordWrapping_75);
            // args = new Type[]{};
            // method = type.GetMethod("get_wordWrappingRatios", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_wordWrappingRatios_76);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_wordWrappingRatios", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_wordWrappingRatios_77);
            // args = new Type[]{};
            // method = type.GetMethod("get_overflowMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_overflowMode_78);
            // args = new Type[]{typeof(TMPro.TextOverflowModes)};
            // method = type.GetMethod("set_overflowMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_overflowMode_79);
            // args = new Type[]{};
            // method = type.GetMethod("get_isTextOverflowing", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isTextOverflowing_80);
            // args = new Type[]{};
            // method = type.GetMethod("get_firstOverflowCharacterIndex", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_firstOverflowCharacterIndex_81);
            // args = new Type[]{};
            // method = type.GetMethod("get_linkedTextComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_linkedTextComponent_82);
            // args = new Type[]{typeof(TMPro.TMP_Text)};
            // method = type.GetMethod("set_linkedTextComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_linkedTextComponent_83);
            // args = new Type[]{};
            // method = type.GetMethod("get_isTextTruncated", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isTextTruncated_84);
            // args = new Type[]{};
            // method = type.GetMethod("get_enableKerning", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_enableKerning_85);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_enableKerning", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_enableKerning_86);
            // args = new Type[]{};
            // method = type.GetMethod("get_extraPadding", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_extraPadding_87);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_extraPadding", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_extraPadding_88);
            // args = new Type[]{};
            // method = type.GetMethod("get_richText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_richText_89);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_richText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_richText_90);
            // args = new Type[]{};
            // method = type.GetMethod("get_parseCtrlCharacters", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_parseCtrlCharacters_91);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_parseCtrlCharacters", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_parseCtrlCharacters_92);
            // args = new Type[]{};
            // method = type.GetMethod("get_isOverlay", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isOverlay_93);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isOverlay", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isOverlay_94);
            // args = new Type[]{};
            // method = type.GetMethod("get_isOrthographic", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isOrthographic_95);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isOrthographic", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isOrthographic_96);
            // args = new Type[]{};
            // method = type.GetMethod("get_enableCulling", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_enableCulling_97);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_enableCulling", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_enableCulling_98);
            // args = new Type[]{};
            // method = type.GetMethod("get_ignoreVisibility", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_ignoreVisibility_99);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_ignoreVisibility", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_ignoreVisibility_100);
            // args = new Type[]{};
            // method = type.GetMethod("get_horizontalMapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_horizontalMapping_101);
            // args = new Type[]{typeof(TMPro.TextureMappingOptions)};
            // method = type.GetMethod("set_horizontalMapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_horizontalMapping_102);
            // args = new Type[]{};
            // method = type.GetMethod("get_verticalMapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_verticalMapping_103);
            // args = new Type[]{typeof(TMPro.TextureMappingOptions)};
            // method = type.GetMethod("set_verticalMapping", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_verticalMapping_104);
            // args = new Type[]{};
            // method = type.GetMethod("get_mappingUvLineOffset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_mappingUvLineOffset_105);
            // args = new Type[]{typeof(System.Single)};
            // method = type.GetMethod("set_mappingUvLineOffset", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_mappingUvLineOffset_106);
            // args = new Type[]{};
            // method = type.GetMethod("get_renderMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_renderMode_107);
            // args = new Type[]{typeof(TMPro.TextRenderFlags)};
            // method = type.GetMethod("set_renderMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_renderMode_108);
            // args = new Type[]{};
            // method = type.GetMethod("get_geometrySortingOrder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_geometrySortingOrder_109);
            // args = new Type[]{typeof(TMPro.VertexSortingOrder)};
            // method = type.GetMethod("set_geometrySortingOrder", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_geometrySortingOrder_110);
            // args = new Type[]{};
            // method = type.GetMethod("get_isTextObjectScaleStatic", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isTextObjectScaleStatic_111);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isTextObjectScaleStatic", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isTextObjectScaleStatic_112);
            // args = new Type[]{};
            // method = type.GetMethod("get_vertexBufferAutoSizeReduction", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_vertexBufferAutoSizeReduction_113);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_vertexBufferAutoSizeReduction", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_vertexBufferAutoSizeReduction_114);
            // args = new Type[]{};
            // method = type.GetMethod("get_firstVisibleCharacter", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_firstVisibleCharacter_115);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_firstVisibleCharacter", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_firstVisibleCharacter_116);
            // args = new Type[]{};
            // method = type.GetMethod("get_maxVisibleCharacters", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maxVisibleCharacters_117);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_maxVisibleCharacters", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_maxVisibleCharacters_118);
            // args = new Type[]{};
            // method = type.GetMethod("get_maxVisibleWords", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maxVisibleWords_119);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_maxVisibleWords", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_maxVisibleWords_120);
            // args = new Type[]{};
            // method = type.GetMethod("get_maxVisibleLines", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maxVisibleLines_121);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_maxVisibleLines", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_maxVisibleLines_122);
            // args = new Type[]{};
            // method = type.GetMethod("get_useMaxVisibleDescender", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_useMaxVisibleDescender_123);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_useMaxVisibleDescender", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_useMaxVisibleDescender_124);
            // args = new Type[]{};
            // method = type.GetMethod("get_pageToDisplay", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_pageToDisplay_125);
            // args = new Type[]{typeof(System.Int32)};
            // method = type.GetMethod("set_pageToDisplay", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_pageToDisplay_126);
            // args = new Type[]{};
            // method = type.GetMethod("get_margin", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_margin_127);
            // args = new Type[]{typeof(UnityEngine.Vector4)};
            // method = type.GetMethod("set_margin", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_margin_128);
            // args = new Type[]{};
            // method = type.GetMethod("get_textInfo", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textInfo_129);
            // args = new Type[]{};
            // method = type.GetMethod("get_havePropertiesChanged", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_havePropertiesChanged_130);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_havePropertiesChanged", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_havePropertiesChanged_131);
            // args = new Type[]{};
            // method = type.GetMethod("get_isUsingLegacyAnimationComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isUsingLegacyAnimationComponent_132);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isUsingLegacyAnimationComponent", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isUsingLegacyAnimationComponent_133);
            // args = new Type[]{};
            // method = type.GetMethod("get_transform", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_transform_134);
            // args = new Type[]{};
            // method = type.GetMethod("get_rectTransform", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_rectTransform_135);
            // args = new Type[]{};
            // method = type.GetMethod("get_autoSizeTextContainer", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_autoSizeTextContainer_136);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_autoSizeTextContainer", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_autoSizeTextContainer_137);
            // args = new Type[]{};
            // method = type.GetMethod("get_mesh", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_mesh_138);
            // args = new Type[]{};
            // method = type.GetMethod("get_isVolumetricText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_isVolumetricText_139);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("set_isVolumetricText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_isVolumetricText_140);
            // args = new Type[]{};
            // method = type.GetMethod("get_bounds", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_bounds_141);
            // args = new Type[]{};
            // method = type.GetMethod("get_textBounds", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_textBounds_142);
            // args = new Type[]{typeof(System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>)};
            // method = type.GetMethod("add_OnFontAssetRequest", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, add_OnFontAssetRequest_143);
            // args = new Type[]{typeof(System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>)};
            // method = type.GetMethod("remove_OnFontAssetRequest", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, remove_OnFontAssetRequest_144);
            // args = new Type[]{typeof(System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>)};
            // method = type.GetMethod("add_OnSpriteAssetRequest", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, add_OnSpriteAssetRequest_145);
            // args = new Type[]{typeof(System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>)};
            // method = type.GetMethod("remove_OnSpriteAssetRequest", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, remove_OnSpriteAssetRequest_146);
            // args = new Type[]{typeof(System.Action<TMPro.TMP_TextInfo>)};
            // method = type.GetMethod("add_OnPreRenderText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, add_OnPreRenderText_147);
            // args = new Type[]{typeof(System.Action<TMPro.TMP_TextInfo>)};
            // method = type.GetMethod("remove_OnPreRenderText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, remove_OnPreRenderText_148);
            // args = new Type[]{};
            // method = type.GetMethod("get_flexibleHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_flexibleHeight_149);
            // args = new Type[]{};
            // method = type.GetMethod("get_flexibleWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_flexibleWidth_150);
            // args = new Type[]{};
            // method = type.GetMethod("get_minWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_minWidth_151);
            // args = new Type[]{};
            // method = type.GetMethod("get_minHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_minHeight_152);
            // args = new Type[]{};
            // method = type.GetMethod("get_maxWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maxWidth_153);
            // args = new Type[]{};
            // method = type.GetMethod("get_maxHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_maxHeight_154);
            // args = new Type[]{};
            // method = type.GetMethod("get_preferredWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_preferredWidth_155);
            // args = new Type[]{};
            // method = type.GetMethod("get_preferredHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_preferredHeight_156);
            // args = new Type[]{};
            // method = type.GetMethod("get_renderedWidth", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_renderedWidth_157);
            // args = new Type[]{};
            // method = type.GetMethod("get_renderedHeight", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_renderedHeight_158);
            // args = new Type[]{};
            // method = type.GetMethod("get_layoutPriority", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_layoutPriority_159);
            // args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            // method = type.GetMethod("ForceMeshUpdate", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ForceMeshUpdate_160);
            // args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32)};
            // method = type.GetMethod("UpdateGeometry", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateGeometry_161);
            // args = new Type[]{typeof(TMPro.TMP_VertexDataUpdateFlags)};
            // method = type.GetMethod("UpdateVertexData", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateVertexData_162);
            // args = new Type[]{};
            // method = type.GetMethod("UpdateVertexData", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateVertexData_163);
            // args = new Type[]{typeof(UnityEngine.Vector3[])};
            // method = type.GetMethod("SetVertices", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetVertices_164);
            // args = new Type[]{};
            // method = type.GetMethod("UpdateMeshPadding", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, UpdateMeshPadding_165);
            // args = new Type[]{typeof(UnityEngine.Color), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean)};
            // method = type.GetMethod("CrossFadeColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CrossFadeColor_166);
            // args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Boolean)};
            // method = type.GetMethod("CrossFadeAlpha", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, CrossFadeAlpha_167);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_168);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_169);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_170);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_171);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_172);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_173);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_174);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_175);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_176);
            args = new Type[]{typeof(System.Text.StringBuilder)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_177);
            args = new Type[]{typeof(System.Char[])};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_178);
            args = new Type[]{typeof(System.Char[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetText_179);
            args = new Type[]{typeof(System.Char[])};
            method = type.GetMethod("SetCharArray", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetCharArray_180);
            // args = new Type[]{typeof(System.Char[]), typeof(System.Int32), typeof(System.Int32)};
            // method = type.GetMethod("SetCharArray", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetCharArray_181);
            // args = new Type[]{};
            // method = type.GetMethod("GetPreferredValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetPreferredValues_182);
            // args = new Type[]{typeof(System.Single), typeof(System.Single)};
            // method = type.GetMethod("GetPreferredValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetPreferredValues_183);
            // args = new Type[]{typeof(System.String)};
            // method = type.GetMethod("GetPreferredValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetPreferredValues_184);
            // args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single)};
            // method = type.GetMethod("GetPreferredValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetPreferredValues_185);
            // args = new Type[]{};
            // method = type.GetMethod("GetRenderedValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetRenderedValues_186);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("GetRenderedValues", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetRenderedValues_187);
            // args = new Type[]{typeof(System.String)};
            // method = type.GetMethod("GetTextInfo", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetTextInfo_188);
            // args = new Type[]{};
            // method = type.GetMethod("ComputeMarginSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ComputeMarginSize_189);
            // args = new Type[]{};
            // method = type.GetMethod("ClearMesh", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ClearMesh_190);
            // args = new Type[]{typeof(System.Boolean)};
            // method = type.GetMethod("ClearMesh", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ClearMesh_191);
            // args = new Type[]{};
            // method = type.GetMethod("GetParsedText", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetParsedText_192);



            app.RegisterCLRCreateArrayInstance(type, s => new TMPro.TMP_Text[s]);


        }


        static StackObject* get_text_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.text;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_text_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.text = value;

            return __ret;
        }

        // static StackObject* get_textPreprocessor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textPreprocessor;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_textPreprocessor_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.ITextPreprocessor @value = (TMPro.ITextPreprocessor)typeof(TMPro.ITextPreprocessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.textPreprocessor = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isRightToLeftText_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isRightToLeftText;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isRightToLeftText_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isRightToLeftText = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_font_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.font;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_font_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.font = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontSharedMaterial_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontSharedMaterial;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontSharedMaterial_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontSharedMaterial = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontSharedMaterials_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontSharedMaterials;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontSharedMaterials_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Material[] @value = (UnityEngine.Material[])typeof(UnityEngine.Material[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontSharedMaterials = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontMaterial_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontMaterial;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontMaterial_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Material @value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontMaterial = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontMaterials_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontMaterials;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontMaterials_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Material[] @value = (UnityEngine.Material[])typeof(UnityEngine.Material[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontMaterials = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_color_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.color;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_color_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.color = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_alpha_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.alpha;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_alpha_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.alpha = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_enableVertexGradient_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.enableVertexGradient;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_enableVertexGradient_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.enableVertexGradient = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_colorGradient_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.colorGradient;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_colorGradient_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.VertexGradient @value = (TMPro.VertexGradient)typeof(TMPro.VertexGradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.colorGradient = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_colorGradientPreset_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.colorGradientPreset;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_colorGradientPreset_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_ColorGradient @value = (TMPro.TMP_ColorGradient)typeof(TMPro.TMP_ColorGradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.colorGradientPreset = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_spriteAsset_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.spriteAsset;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_spriteAsset_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_SpriteAsset @value = (TMPro.TMP_SpriteAsset)typeof(TMPro.TMP_SpriteAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.spriteAsset = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_tintAllSprites_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.tintAllSprites;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_tintAllSprites_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.tintAllSprites = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_styleSheet_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.styleSheet;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_styleSheet_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_StyleSheet @value = (TMPro.TMP_StyleSheet)typeof(TMPro.TMP_StyleSheet).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.styleSheet = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_textStyle_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textStyle;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_textStyle_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Style @value = (TMPro.TMP_Style)typeof(TMPro.TMP_Style).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.textStyle = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_overrideColorTags_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.overrideColorTags;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_overrideColorTags_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.overrideColorTags = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_faceColor_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.faceColor;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_faceColor_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Color32 @value = (UnityEngine.Color32)typeof(UnityEngine.Color32).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.faceColor = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_outlineColor_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.outlineColor;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_outlineColor_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Color32 @value = (UnityEngine.Color32)typeof(UnityEngine.Color32).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.outlineColor = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_outlineWidth_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.outlineWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_outlineWidth_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.outlineWidth = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontSize_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontSize;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_fontSize_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontSize = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontWeight_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontWeight;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontWeight_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.FontWeight @value = (TMPro.FontWeight)typeof(TMPro.FontWeight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontWeight = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_pixelsPerUnit_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.pixelsPerUnit;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_enableAutoSizing_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.enableAutoSizing;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_enableAutoSizing_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.enableAutoSizing = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontSizeMin_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontSizeMin;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_fontSizeMin_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontSizeMin = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontSizeMax_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontSizeMax;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_fontSizeMax_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontSizeMax = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_fontStyle_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.fontStyle;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_fontStyle_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.FontStyles @value = (TMPro.FontStyles)typeof(TMPro.FontStyles).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.fontStyle = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isUsingBold_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isUsingBold;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_horizontalAlignment_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.horizontalAlignment;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_horizontalAlignment_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.HorizontalAlignmentOptions @value = (TMPro.HorizontalAlignmentOptions)typeof(TMPro.HorizontalAlignmentOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.horizontalAlignment = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_verticalAlignment_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.verticalAlignment;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_verticalAlignment_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.VerticalAlignmentOptions @value = (TMPro.VerticalAlignmentOptions)typeof(TMPro.VerticalAlignmentOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.verticalAlignment = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_alignment_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.alignment;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_alignment_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextAlignmentOptions @value = (TMPro.TextAlignmentOptions)typeof(TMPro.TextAlignmentOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.alignment = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_characterSpacing_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.characterSpacing;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_characterSpacing_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.characterSpacing = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_wordSpacing_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.wordSpacing;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_wordSpacing_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.wordSpacing = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_lineSpacing_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.lineSpacing;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_lineSpacing_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.lineSpacing = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_lineSpacingAdjustment_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.lineSpacingAdjustment;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_lineSpacingAdjustment_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.lineSpacingAdjustment = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_paragraphSpacing_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.paragraphSpacing;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_paragraphSpacing_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.paragraphSpacing = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_characterWidthAdjustment_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.characterWidthAdjustment;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_characterWidthAdjustment_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.characterWidthAdjustment = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_enableWordWrapping_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.enableWordWrapping;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_enableWordWrapping_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.enableWordWrapping = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_wordWrappingRatios_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.wordWrappingRatios;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_wordWrappingRatios_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.wordWrappingRatios = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_overflowMode_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.overflowMode;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_overflowMode_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextOverflowModes @value = (TMPro.TextOverflowModes)typeof(TMPro.TextOverflowModes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.overflowMode = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isTextOverflowing_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isTextOverflowing;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_firstOverflowCharacterIndex_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.firstOverflowCharacterIndex;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_linkedTextComponent_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.linkedTextComponent;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_linkedTextComponent_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.linkedTextComponent = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isTextTruncated_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isTextTruncated;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_enableKerning_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.enableKerning;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_enableKerning_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.enableKerning = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_extraPadding_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.extraPadding;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_extraPadding_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.extraPadding = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_richText_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.richText;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_richText_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.richText = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_parseCtrlCharacters_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.parseCtrlCharacters;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_parseCtrlCharacters_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.parseCtrlCharacters = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isOverlay_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isOverlay;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isOverlay_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isOverlay = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isOrthographic_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isOrthographic;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isOrthographic_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isOrthographic = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_enableCulling_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.enableCulling;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_enableCulling_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.enableCulling = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_ignoreVisibility_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.ignoreVisibility;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_ignoreVisibility_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ignoreVisibility = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_horizontalMapping_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.horizontalMapping;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_horizontalMapping_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextureMappingOptions @value = (TMPro.TextureMappingOptions)typeof(TMPro.TextureMappingOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.horizontalMapping = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_verticalMapping_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.verticalMapping;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_verticalMapping_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextureMappingOptions @value = (TMPro.TextureMappingOptions)typeof(TMPro.TextureMappingOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.verticalMapping = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_mappingUvLineOffset_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.mappingUvLineOffset;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_mappingUvLineOffset_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @value = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.mappingUvLineOffset = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_renderMode_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.renderMode;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_renderMode_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TextRenderFlags @value = (TMPro.TextRenderFlags)typeof(TMPro.TextRenderFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.renderMode = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_geometrySortingOrder_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.geometrySortingOrder;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_geometrySortingOrder_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.VertexSortingOrder @value = (TMPro.VertexSortingOrder)typeof(TMPro.VertexSortingOrder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.geometrySortingOrder = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isTextObjectScaleStatic_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isTextObjectScaleStatic;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isTextObjectScaleStatic_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isTextObjectScaleStatic = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_vertexBufferAutoSizeReduction_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.vertexBufferAutoSizeReduction;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_vertexBufferAutoSizeReduction_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.vertexBufferAutoSizeReduction = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_firstVisibleCharacter_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.firstVisibleCharacter;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_firstVisibleCharacter_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.firstVisibleCharacter = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_maxVisibleCharacters_117(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maxVisibleCharacters;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_maxVisibleCharacters_118(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.maxVisibleCharacters = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_maxVisibleWords_119(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maxVisibleWords;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_maxVisibleWords_120(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.maxVisibleWords = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_maxVisibleLines_121(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maxVisibleLines;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_maxVisibleLines_122(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.maxVisibleLines = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_useMaxVisibleDescender_123(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.useMaxVisibleDescender;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_useMaxVisibleDescender_124(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.useMaxVisibleDescender = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_pageToDisplay_125(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.pageToDisplay;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_pageToDisplay_126(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @value = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.pageToDisplay = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_margin_127(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.margin;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* set_margin_128(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.margin = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_textInfo_129(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textInfo;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* get_havePropertiesChanged_130(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.havePropertiesChanged;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_havePropertiesChanged_131(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.havePropertiesChanged = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_isUsingLegacyAnimationComponent_132(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isUsingLegacyAnimationComponent;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isUsingLegacyAnimationComponent_133(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isUsingLegacyAnimationComponent = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_transform_134(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.transform;
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* get_rectTransform_135(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.rectTransform;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* get_autoSizeTextContainer_136(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.autoSizeTextContainer;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_autoSizeTextContainer_137(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.autoSizeTextContainer = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_mesh_138(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.mesh;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* get_isVolumetricText_139(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.isVolumetricText;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }
        //
        // static StackObject* set_isVolumetricText_140(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @value = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.isVolumetricText = value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_bounds_141(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.bounds;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* get_textBounds_142(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.textBounds;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* add_OnFontAssetRequest_143(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Func<System.Int32, System.String, TMPro.TMP_FontAsset> @value = (System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>)typeof(System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     TMPro.TMP_Text.OnFontAssetRequest += value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* remove_OnFontAssetRequest_144(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Func<System.Int32, System.String, TMPro.TMP_FontAsset> @value = (System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>)typeof(System.Func<System.Int32, System.String, TMPro.TMP_FontAsset>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     TMPro.TMP_Text.OnFontAssetRequest -= value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* add_OnSpriteAssetRequest_145(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset> @value = (System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>)typeof(System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     TMPro.TMP_Text.OnSpriteAssetRequest += value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* remove_OnSpriteAssetRequest_146(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset> @value = (System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>)typeof(System.Func<System.Int32, System.String, TMPro.TMP_SpriteAsset>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     TMPro.TMP_Text.OnSpriteAssetRequest -= value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* add_OnPreRenderText_147(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPreRenderText += value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* remove_OnPreRenderText_148(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.OnPreRenderText -= value;
        //
        //     return __ret;
        // }
        //
        // static StackObject* get_flexibleHeight_149(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.flexibleHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_flexibleWidth_150(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.flexibleWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_minWidth_151(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.minWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_minHeight_152(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.minHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_maxWidth_153(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maxWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_maxHeight_154(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.maxHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_preferredWidth_155(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.preferredWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_preferredHeight_156(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.preferredHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_renderedWidth_157(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.renderedWidth;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_renderedHeight_158(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.renderedHeight;
        //
        //     __ret->ObjectType = ObjectTypes.Float;
        //     *(float*)&__ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* get_layoutPriority_159(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.layoutPriority;
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }
        //
        // static StackObject* ForceMeshUpdate_160(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ForceMeshUpdate(@ignoreActiveState, @forceTextReparsing);
        //
        //     return __ret;
        // }
        //
        // static StackObject* UpdateGeometry_161(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateGeometry(@mesh, @index);
        //
        //     return __ret;
        // }
        //
        // static StackObject* UpdateVertexData_162(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateVertexData(@flags);
        //
        //     return __ret;
        // }
        //
        // static StackObject* UpdateVertexData_163(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateVertexData();
        //
        //     return __ret;
        // }
        //
        // static StackObject* SetVertices_164(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3[] @vertices = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetVertices(@vertices);
        //
        //     return __ret;
        // }
        //
        // static StackObject* UpdateMeshPadding_165(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.UpdateMeshPadding();
        //
        //     return __ret;
        // }
        //
        // static StackObject* CrossFadeColor_166(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 5);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @useAlpha = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Boolean @ignoreTimeScale = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.Single @duration = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
        //     UnityEngine.Color @targetColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CrossFadeColor(@targetColor, @duration, @ignoreTimeScale, @useAlpha);
        //
        //     return __ret;
        // }
        //
        // static StackObject* CrossFadeAlpha_167(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 4);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @ignoreTimeScale = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Single @duration = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.Single @alpha = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.CrossFadeAlpha(@alpha, @duration, @ignoreTimeScale);
        //
        //     return __ret;
        // }
        //
        static StackObject* SetText_168(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @syncTextInputBox = ptr_of_this_method->Value == 1;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @syncTextInputBox);
        
            return __ret;
        }
        
        static StackObject* SetText_169(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0);
        
            return __ret;
        }
        
        static StackObject* SetText_170(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1);
        
            return __ret;
        }
        
        static StackObject* SetText_171(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2);
        
            return __ret;
        }
        
        static StackObject* SetText_172(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg3 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2, @arg3);
        
            return __ret;
        }
        
        static StackObject* SetText_173(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg4 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg3 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2, @arg3, @arg4);
        
            return __ret;
        }
        
        static StackObject* SetText_174(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg5 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg4 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg3 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2, @arg3, @arg4, @arg5);
        
            return __ret;
        }
        
        static StackObject* SetText_175(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg6 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg5 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg4 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @arg3 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2, @arg3, @arg4, @arg5, @arg6);
        
            return __ret;
        }
        
        static StackObject* SetText_176(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @arg7 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @arg6 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @arg5 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @arg4 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @arg3 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @arg2 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Single @arg1 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Single @arg0 = *(float*)&ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.String @sourceText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @arg0, @arg1, @arg2, @arg3, @arg4, @arg5, @arg6, @arg7);
        
            return __ret;
        }
        
        static StackObject* SetText_177(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Text.StringBuilder @sourceText = (System.Text.StringBuilder)typeof(System.Text.StringBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText);
        
            return __ret;
        }
        
        static StackObject* SetText_178(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char[] @sourceText = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText);
        
            return __ret;
        }
        
        static StackObject* SetText_179(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @length = ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @start = ptr_of_this_method->Value;
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char[] @sourceText = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetText(@sourceText, @start, @length);
        
            return __ret;
        }
        
        static StackObject* SetCharArray_180(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char[] @sourceText = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);
        
            instance_of_this_method.SetCharArray(@sourceText);
        
            return __ret;
        }
        //
        // static StackObject* SetCharArray_181(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 4);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @length = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Int32 @start = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.Char[] @sourceText = (System.Char[])typeof(System.Char[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetCharArray(@sourceText, @start, @length);
        //
        //     return __ret;
        // }
        //
        // static StackObject* GetPreferredValues_182(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetPreferredValues();
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetPreferredValues_183(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @height = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Single @width = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetPreferredValues(@width, @height);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetPreferredValues_184(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetPreferredValues(@text);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetPreferredValues_185(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 4);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Single @height = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Single @width = *(float*)&ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetPreferredValues(@text, @width, @height);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetRenderedValues_186(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetRenderedValues();
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetRenderedValues_187(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @onlyVisibleCharacters = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetRenderedValues(@onlyVisibleCharacters);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* GetTextInfo_188(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetTextInfo(@text);
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        //
        // static StackObject* ComputeMarginSize_189(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ComputeMarginSize();
        //
        //     return __ret;
        // }
        //
        // static StackObject* ClearMesh_190(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ClearMesh();
        //
        //     return __ret;
        // }
        //
        // static StackObject* ClearMesh_191(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Boolean @uploadGeometry = ptr_of_this_method->Value == 1;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ClearMesh(@uploadGeometry);
        //
        //     return __ret;
        // }
        //
        // static StackObject* GetParsedText_192(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     TMPro.TMP_Text instance_of_this_method = (TMPro.TMP_Text)typeof(TMPro.TMP_Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetParsedText();
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }





    }
}
