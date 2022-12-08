using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;
using com.phantoms.BaseFeatures.Runtime;
using com.phantoms.BaseFeatures.Runtime;
//using com.PhantomsXR.BarracudaExtension.Runtime;
using ILRuntime.CLRBinding.Adapter;
#if UNITY_EDITOR
using UnityEditor;
using System;
using System.Collections.Generic;
using com.Phantoms.ARMODPackageTools.Runtime;
using com.PhantomsXR.MirrorExtension.Runtime;
using Mirror;
using TMPro;
//using Unity.Barracuda;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using XRMODEngineCore.Runtime;


[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeCLRBinding
{
    [MenuItem("Tools/ILRuntime/Generate CLR Binding Code")]
    // ReSharper disable once InconsistentNaming
    public static void GenerateCLRBinding()
    {
        var tmp_SavePath = EditorUtility.SaveFolderPanel("Save generated code", "Assets", "");

        if (string.IsNullOrEmpty(tmp_SavePath)) return;

        List<Type> tmp_Types = new List<Type>
        {
            // Write your type in here
        };

        ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_Types, tmp_SavePath);
    }

    [MenuItem("Tools/ILRuntime/Generate CLR Binding Code by Analysis")]
    // ReSharper disable once InconsistentNaming
    static void GenerateCLRBindingByAnalysis()
    {
        string tmp_DllPath = EditorUtility.OpenFilePanel("Select the dll", "", "dll,bytes");

        if (string.IsNullOrEmpty(tmp_DllPath)) return;
        string tmp_ScriptFolderPath = EditorUtility.SaveFolderPanel("Saved Script folder", "", "");

        ILRuntime.Runtime.Enviorment.AppDomain tmp_Domain = new ILRuntime.Runtime.Enviorment.AppDomain();
        using (System.IO.FileStream tmp_Fs = new System.IO.FileStream(tmp_DllPath,
                   System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            tmp_Domain.LoadAssembly(tmp_Fs);

            //Crossbind Adapter is needed to generate the correct binding code
            InitILRuntime(tmp_Domain);
            ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_Domain, tmp_ScriptFolderPath);
        }
    }

    static void InitILRuntime(ILRuntime.Runtime.Enviorment.AppDomain _domain)
    {
        _domain.RegisterCrossBindingAdaptor(new XRMODBehaviourAdapter());
        _domain.RegisterCrossBindingAdaptor(new UIMonoBehaviourAdaptor());
        _domain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        _domain.RegisterCrossBindingAdaptor(new AsyncStateMachineClassInheritanceAdaptor());
        _domain.RegisterCrossBindingAdaptor(new BaseNotificationDataAdapter());
    }

    [MenuItem("Tools/ILRuntime/Generate cross-domain inheritance adapter")]
    static void GenerateCrossbindAdapter()
    {
        var tmp_Path = EditorUtility.SaveFilePanel("Save Adapter", "Assets", "Adapter", "cs");
        if (string.IsNullOrEmpty(tmp_Path)) return;

        using (System.IO.StreamWriter tmp_SW = new System.IO.StreamWriter(tmp_Path))
        {
            tmp_SW.WriteLine(
                ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(
                    typeof(TeleportationProvider),
                    "ILRuntime.CLRBinding.Adapter"));
        }

        AssetDatabase.Refresh();
    }
}
#endif