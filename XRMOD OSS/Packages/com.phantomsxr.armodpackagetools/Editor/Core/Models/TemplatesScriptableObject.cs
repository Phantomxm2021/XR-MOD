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

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace com.Phantoms.ARMODPackageTools.Core
{
    [System.Serializable]
    public class TemplateDataModel
    {
        public string TemplateDisplayName;
        public string TemplateName;
        public string TemplateDescription;
        public string TemplateIcon;
        public string TemplatePath;
        public string TemplateAuthor;
        public string TemplateLicense;
        public string TemplateType="C Sharp";
        public string TemplateVersion="1.0.0";
        [HideInInspector] public int ID;
    }

    public class TemplatesScriptableObject : ScriptableObject
    {
         public List<TemplateDataModel> Templates;
         
        private void OnDisable()
        {
            EditorUtility.SetDirty(this);
        }
    }
}