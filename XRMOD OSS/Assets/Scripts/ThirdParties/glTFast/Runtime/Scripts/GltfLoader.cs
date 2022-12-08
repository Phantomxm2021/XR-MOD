// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AR-MOD SDK.
// //
// // The AR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLTFast.Loading;
using GLTFast.Logging;
using GLTFast.Materials;
using UnityEngine;

namespace GLTFast
{
    public class GltfLoader : GltfAsset
    {
        [Tooltip("Create a box collider encapsulating the glTF asset")]
        public bool createBoxCollider = true;

        [NonSerialized] public Bounds bounds;
        public GameObject LoadedGameObject { get; private set; }

        public override async Task<bool> Load(
            string url,
            IDownloadProvider downloadProvider = null,
            IDeferAgent deferAgent = null,
            IMaterialGenerator materialGenerator = null,
            ICodeLogger logger = null
        )
        {
            importer = new GltfImport(downloadProvider, deferAgent, materialGenerator);
            var success = await importer.Load(url);
            if (success)
            {
                var insta = (GameObjectBoundsInstantiator) GetDefaultInstantiator(logger);
                // Auto-Instantiate
                if (sceneId >= 0)
                {
                    success = await importer.InstantiateScene(insta, sceneId);
                    currentSceneId = success ? sceneId : (int?) null;
                }
                else
                {
                    success = await importer.InstantiateMainScene(insta);
                    currentSceneId = importer.defaultSceneIndex;
                }

                sceneInstance = insta.sceneInstance;

                if (success)
                {
                    SetBounds(insta);
                }
            }

            return success;
        }

        public override async Task<bool> InstantiateScene(int sceneIndex, ICodeLogger logger = null)
        {
            var instantiator = (GameObjectBoundsInstantiator) GetDefaultInstantiator(logger);
            var success = await base.InstantiateScene(sceneIndex, instantiator);
            currentSceneId = success ? sceneIndex : (int?) null;
            sceneInstance = instantiator.sceneInstance;
            if (success)
            {
                if (sceneInstance.cameras is {Count: > 0})
                {
                    foreach (Camera tmp_Camera in sceneInstance.cameras)
                    {
                        tmp_Camera.enabled = false;
                    }
                }

                SetBounds(instantiator);
                LoadedGameObject = this.gameObject;
            }

            return success;
        }

        protected override IInstantiator GetDefaultInstantiator(ICodeLogger logger)
        {
            return new GameObjectBoundsInstantiator(importer, transform, logger);
        }


        void SetBounds(GameObjectBoundsInstantiator insta)
        {
            var sceneBounds = insta.sceneInstance != null ? insta.CalculateBounds() : null;
            if (sceneBounds.HasValue)
            {
                bounds = sceneBounds.Value;
                if (createBoxCollider)
                {
#if UNITY_PHYSICS
                    var boxCollider = gameObject.AddComponent<BoxCollider>();
                    boxCollider.center = bounds.center;
                    boxCollider.size = bounds.size;
#else
                    Debug.LogError("GltfBoundsAsset requires the built-in Physics package to be enabled (in the Package Manager)");
#endif
                }
            }
        }
    }

    public static class ExtensionFroTransform
    {
        public static List<GameObject> GetAllChildren(this Transform _parent)
        {
            List<GameObject> tmp_Children = new List<GameObject>();

            Queue<Transform> tmp_Queue = new Queue<Transform>();
            tmp_Queue.Enqueue(_parent);
            while (tmp_Queue.Count > 0)
            {
                var c = tmp_Queue.Dequeue();

                tmp_Children.Add(c.gameObject);

                foreach (Transform t in c)
                    tmp_Queue.Enqueue(t);
            }

            return tmp_Children;
        }
    }
}