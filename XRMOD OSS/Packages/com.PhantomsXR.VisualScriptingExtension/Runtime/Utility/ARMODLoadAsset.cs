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

using System.Collections;
using com.Phantoms.ARMODAPI.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Video;

namespace com.PhantomsXR.VisualScriptingExtension.Runtime
{
    public enum LoadTypeEnum
    {
        GameObject,
        Texture,
        Sprite,
        TextAsset,
        AudioClip,
        VideoClip,
        Font,
        AnimationClip,
        ComputeShader,
        SpriteAtlas,
        Material,
    }

    [UnitCategory("ARMOD/Utility"), UnitTitle("Load Asset(Async)")]
    [TypeIcon(typeof(GameObject))]
    public class ARMODLoadAsset : Unit
    {
        [DoNotSerialize] [PortLabelHidden] public ControlInput inputTrigger;
        [DoNotSerialize] [PortLabelHidden] public ControlOutput outputTrigger;
        [DoNotSerialize] [PortLabel("Name")] public ValueInput WannaLoadGameObjectName;
        [DoNotSerialize] public ValueInput LoadType;
        [DoNotSerialize] public ValueInput Api;

        [DoNotSerialize] public ValueOutput Result;

        private UnityEngine.Object resultUnityEngineObject;

        protected override void Definition()
        {
            inputTrigger = ControlInputCoroutine(nameof(inputTrigger), Execute);
            outputTrigger = ControlOutput(nameof(outputTrigger));


            WannaLoadGameObjectName = ValueInput(nameof(WannaLoadGameObjectName), (string) null);
            Api = ValueInput<API>(nameof(API));
            LoadType = ValueInput(nameof(LoadType), LoadTypeEnum.GameObject);

            Result = ValueOutput(nameof(Result), _flow => resultUnityEngineObject);
            Requirement(WannaLoadGameObjectName, inputTrigger);
            Requirement(Api, inputTrigger);
            Succession(inputTrigger, outputTrigger);
        }


        private IEnumerator Execute(Flow _arg)
        {
            DoLoad(_arg.GetValue<API>(Api), _arg.GetValue<LoadTypeEnum>(LoadType),
                _arg.GetValue<string>(WannaLoadGameObjectName));

            while (!resultUnityEngineObject)
            {
                yield return null;
            }

            yield return outputTrigger;
        }

        private async void DoLoad(API _api, LoadTypeEnum _loadType, string _wannaLoad)
        {
            switch (_loadType)
            {
                case LoadTypeEnum.GameObject:
                    resultUnityEngineObject = await _api.LoadAssetAsync<GameObject>(_wannaLoad);
                    break;
                case LoadTypeEnum.Texture:
                    resultUnityEngineObject = await _api.LoadAssetAsync<Texture>(_wannaLoad);
                    break;
                case LoadTypeEnum.Sprite:
                    resultUnityEngineObject = await _api.LoadAssetAsync<Sprite>(_wannaLoad);
                    break;
                case LoadTypeEnum.TextAsset:
                    resultUnityEngineObject = await _api.LoadAssetAsync<TextAsset>(_wannaLoad);
                    break;
                case LoadTypeEnum.AudioClip:
                    resultUnityEngineObject = await _api.LoadAssetAsync<TextAsset>(_wannaLoad);
                    break;
                case LoadTypeEnum.VideoClip:
                    resultUnityEngineObject = await _api.LoadAssetAsync<VideoClip>(_wannaLoad);
                    break;
                case LoadTypeEnum.Font:
                    resultUnityEngineObject = await _api.LoadAssetAsync<VideoClip>(_wannaLoad);
                    break;
                case LoadTypeEnum.AnimationClip:
                    resultUnityEngineObject = await _api.LoadAssetAsync<AnimationClip>(_wannaLoad);
                    break;
                case LoadTypeEnum.ComputeShader:
                    resultUnityEngineObject = await _api.LoadAssetAsync<ComputeShader>(_wannaLoad);
                    break;
                case LoadTypeEnum.SpriteAtlas:
                    resultUnityEngineObject = await _api.LoadAssetAsync<SpriteAtlas>(_wannaLoad);
                    break;
                case LoadTypeEnum.Material:
                    resultUnityEngineObject = await _api.LoadAssetAsync<Material>(_wannaLoad);
                    break;
            }
        }
    }
}