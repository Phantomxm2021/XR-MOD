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
using UnityEngine;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace com.Phantoms.ILRuntime.Runtime.CodeHook
{
    [Serializable]
    public class MonoField
    {
        public enum FieldTypeEnum
        {
            Number,
            String,
            Bool,
            GameObject,
            UnityComponent,
            ARExperienceResource,
            Enum,
            UnityObjects,
            Primitives,
            Vector2,
            Vector3,
            Vector4,
            Quaternion,
            NotSupported
        }


        [Tooltip("The name of the key to be assigned")]
        public string FieldName;

        [Tooltip("The value of fieldType of non-GameObject and UnityComponent")]
        public string Value;

        [Tooltip("If fieldType is GameObject or UnityComponent, it can be filled here, otherwise it is invalid")]
        public GameObject GameObject;

        public FieldTypeEnum FieldType;

        // public SystemObject Primitives;
        
        [HideInInspector]public List<GameObject> GameObjects;
        [HideInInspector]public List<Texture2D> Textures;
        [HideInInspector]public List<Transform> Transforms;
        [HideInInspector]public List<AudioClip> AudioClips;
        [HideInInspector]public List<Shader> Shaders;
        [HideInInspector]public List<Sprite> Sprites;
        [HideInInspector]public List<Material> Materials;
        [HideInInspector]public List<MeshRenderer> MeshRenderers;
        [HideInInspector]public List<AnimationClip> AnimationClips;
        [HideInInspector]public List<VideoClip> VideoClips;
        [HideInInspector]public List<Mesh> Meshes;
        [HideInInspector]public List<Color> Colors;
        [HideInInspector]public List<MonoBehaviour> MonoBehaviours;
        [HideInInspector]public List<Collider> Colliders;
        [HideInInspector]public List<Animator> Animators;
    }


    [System.Serializable]
    public class UnityObject<T> where T : Object
    {
        public List<T> List;
        public Type ListType;
    }


    [System.Serializable]
    public class GenericPrimitiveObject<T>
    {
        public List<T> List;
        public Type ListType;
    }
}