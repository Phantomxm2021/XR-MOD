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
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace com.Phantoms.ARMODPackageTools.Core
{
    [System.Serializable]
    public class ProjectDetailCacheData
    {
        public int Id;
        public Configures Configures;
        public BuildSettingData BuildSettingData;
        public List<ContentModel> Contents;
        [SerializeField] private List<string> Blocks;
        public string SubPath = string.Empty;
        public List<string> GetBlock => Blocks;

        public string GetProjectPath()
        {
            return $"{Application.dataPath.Replace("/Assets", "")}/{SubPath}";
        }


        public void AddContentElement(ContentModel _content)
        {
            if (Contents.Contains(_content)) return;
            Contents.Add(_content);
        }

        public void RemoveContentElement(ContentModel _content)
        {
            Contents.Remove(_content);
        }


        public ContentModel ContentFind(int _id)
        {
            return Contents.FirstOrDefault(_element => _element.Id == _id);
        }

        
        public void ChangeAssetsPath(string _projectName)
        {
            foreach (ContentModel tmp_Content in Contents)
            {
                var tmp_Obj = AssetDatabase.LoadAssetAtPath<Object>(tmp_Content.AssetPathInUnity);
                if (tmp_Obj) continue;
                var tmp_Idx = tmp_Content.AssetPathInUnity.IndexOf(_projectName, StringComparison.Ordinal);
                int tmp_StartIdx = _projectName.Length + tmp_Idx+1;
                var tmp_TempPath =
                    tmp_Content.AssetPathInUnity.Substring( tmp_StartIdx, tmp_Content.AssetPathInUnity.Length -tmp_StartIdx);
                tmp_Content.AssetPathInUnity =Path.Combine(SubPath,tmp_TempPath);
            }
        }

        public void AddBlockElement(string _element)
        {
            Blocks.Add(_element);
        }

        public void RemoveBlockElement(string _element)
        {
            Blocks.Remove(_element);
        }

        public void RemoveBlockElement(int _idx)
        {
            Blocks.RemoveAt(_idx);
        }


        public ContentModel Find(int _id)
        {
            return Contents.FirstOrDefault(_cache => _cache.Id == _id);
        }
    }
}