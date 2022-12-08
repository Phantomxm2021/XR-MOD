using System;
using System.Collections.Generic;
using com.Phantoms.ARMODPackageTools.Core;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace com.Phantoms.ARMODPackageTools.Core
{
    public class PropertiesRenderer : IMGUIContainer
    {
        private Rect drawArea;
        private Vector2 scrollViewPosition;
        private AlgorithmType currentAlgorithmType;

        //Only Editor,For Avoid duplication
        private Dictionary<string, AbstractBlock> blockSubViewDict;

        private ProjectDetailCacheData editingDetailData;
        private const string CONST_SCRIPT_NAME_SPACE = "com.Phantoms.ARMODPackageTools.Core.";

        private readonly List<string> menuList = new List<string>
        {
            "Algorithm",
            "Version Checker",
            "Programmable",
            "Visualizer/Plane",
            "Visualizer/Point Cloud",
            "Features/ARWorld Scale",
            "Features/iOS/Coaching Overlay(iOS Only)",
            "Features/Environment Probe",
            "Features/Light Estimation",
            "Features/Post Processing",
            "Features/AR Interaction",
            "Features/Immersal",
            "Features/Face Mesh",
            "Features/Occlusion",
            "Graphics/Quality Level",
            "Features/Multiplayer",
            "Features/MediaRecorder",
        };

        private readonly List<string> blocks = new List<string>
        {
            nameof(VersionBlock),
            nameof(AlgorithmBlock),
            nameof(ProgrammableBlock),
            nameof(PlaneVisualizerBlock),
            nameof(PointCloudVisualizerBlock),
            nameof(ARWorldScaleBlock),
            nameof(CoachingOverlayBlock),
            nameof(EnvironmentProbeBlock),
            nameof(LightEstimationBlock),
            nameof(PostProcessingBlock),
            nameof(ARInteractionBlock),
            nameof(ImmersalBlock),
            nameof(FaceMeshBlock),
            nameof(OcclusionBlock),
            nameof(QualityBlock),
            nameof(MultiplayerBlock),
            nameof(MediaRecorderBlock),
        };

        public void Initialization()
        {
            editingDetailData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData().DetailCacheData;
            if (editingDetailData.GetBlock == null) return;
            blockSubViewDict = new Dictionary<string, AbstractBlock>();

            //Add dfault block
            var tmp_FullPathOfAlgorithmBlock = typeof(AlgorithmBlock).FullName;
            var tmp_FullPathOfVersionCheckerBlock = typeof(VersionBlock).FullName;
            var tmp_FullPathOfARWorldScaleBlock = typeof(ARWorldScaleBlock).FullName;
            var tmp_FullPathOfProgrammableBlock = typeof(ProgrammableBlock).FullName;

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfAlgorithmBlock))
            {
                ConvertToBlock(tmp_FullPathOfAlgorithmBlock);
            }

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfVersionCheckerBlock))
            {
                ConvertToBlock(tmp_FullPathOfVersionCheckerBlock);
            }

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfARWorldScaleBlock))
            {
                ConvertToBlock(tmp_FullPathOfARWorldScaleBlock);
            }

            if (!editingDetailData.GetBlock.Contains(tmp_FullPathOfProgrammableBlock))
            {
                ConvertToBlock(tmp_FullPathOfProgrammableBlock);
            }


            currentAlgorithmType = editingDetailData.Configures.Algorithm;
            MappingBlock();

            onGUIHandler = () =>
            {
                drawArea = new Rect(contentRect.x, contentRect.y, contentRect.width, layout.height);
                DrawConfigure();
            };
        }


        private void MappingBlock()
        {
            foreach (var tmp_Block in editingDetailData.GetBlock)
            {
                Type tmp_Type = Type.GetType(tmp_Block);
                if (tmp_Type == null) continue;
                object tmp_Instance =
                    // ReSharper disable once PossiblyMistakenUseOfParamsMethod
                    Activator.CreateInstance(type: tmp_Type, args: editingDetailData.Configures);
                AddBlock(tmp_Instance as AbstractBlock);
            }
        }

        private bool AddBlock(AbstractBlock _abstractBlock)
        {
            var tmp_UniqueId = _abstractBlock.GetType().FullName;
            bool tmp_AlreadyExists =
                blockSubViewDict.TryGetValue(tmp_UniqueId ?? throw new Exception(), out AbstractBlock _);

            if (!tmp_AlreadyExists)
                blockSubViewDict.Add(tmp_UniqueId, _abstractBlock);

            return !tmp_AlreadyExists;
        }


        private void RemoveBlock(string _abstractBlock)
        {
            try
            {
                if (blockSubViewDict.TryGetValue(_abstractBlock, out AbstractBlock tmp_AbstractBlock))
                {
                    switch (editingDetailData.Configures.Algorithm)
                    {
                        case AlgorithmType.Immersal:
                            if (tmp_AbstractBlock.GetType() == typeof(ImmersalBlock))
                                throw new Exception();

                            break;
                        case AlgorithmType.FaceMesh:
                            if (tmp_AbstractBlock.GetType() == typeof(FaceMeshBlock))
                                throw new Exception();
                            break;
                    }

                    if (tmp_AbstractBlock.GetType() == typeof(AlgorithmBlock)
                        || tmp_AbstractBlock.GetType() == typeof(VersionBlock)
                        || tmp_AbstractBlock.GetType() == typeof(ARWorldScaleBlock))
                        throw new Exception("Can not removing");

                    tmp_AbstractBlock.OnRemoved();
                    RemoveBlockCol(tmp_AbstractBlock);
                    blockSubViewDict.Remove(_abstractBlock);
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.ToString());
                EditorUtility.DisplayDialog("Error!", "You can not remove this block!", "Ok");
            }
        }


        private void CachingBlockCol(AbstractBlock _abstractBlock)
        {
            string tmp_BlockName = _abstractBlock.GetType().FullName;
            if (!editingDetailData.GetBlock.Contains(tmp_BlockName))
                editingDetailData.AddBlockElement(tmp_BlockName);
        }

        private void RemoveBlockCol(AbstractBlock _abstractBlock)
        {
            editingDetailData.RemoveBlockElement(_abstractBlock.GetType().FullName);
        }


        private void DrawConfigure()
        {
            CheckDependentBlock();

            scrollViewPosition = EditorGUILayout.BeginScrollView(scrollViewPosition);

            //Draw and add remove button for this block
            foreach (var tmp_Block in editingDetailData.GetBlock)
            {
                if (!blockSubViewDict.TryGetValue(tmp_Block, out AbstractBlock tmp_AbstractBlock)) continue;
                var tmp_Area = tmp_AbstractBlock.DrawBlock(drawArea);
                if (!Utility.RightClicked(tmp_Area)) continue;

                var tmp_Menu = new GenericMenu();
                tmp_Menu.AddItem(new GUIContent("Remove"), false,
                    () => { RemoveBlock(tmp_Block); });
                tmp_Menu.ShowAsContext();
                EditorGUILayout.EndScrollView();
                return;
            }


            GUILayout.Space(20);

            //Paint only when the number of blocks is 1
            if (editingDetailData.GetBlock.Count <= 1)
            {
                EditorGUILayout.BeginVertical();
                GUILayout.FlexibleSpace();
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                EditorGUILayout.HelpBox(" Right-click to add configuration options ", MessageType.Info);
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.EndScrollView();
            if (!Utility.RightClicked(drawArea)) return;
            RightClickedMenu();
        }

        private void CheckDependentBlock()
        {
            if (currentAlgorithmType == editingDetailData.Configures.Algorithm) return;
            currentAlgorithmType = editingDetailData.Configures.Algorithm;

            //Remove immersal block when algorithm is not immersal
            if (editingDetailData.Configures.Algorithm != AlgorithmType.Immersal)
            {
                var tmp_BlockFullName = typeof(ImmersalBlock).FullName;
                if (editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                {
                    RemoveBlock(tmp_BlockFullName);
                }
            }

            // algorithm is immersal it will add automatic
            if (editingDetailData.Configures.Algorithm == AlgorithmType.Immersal)
            {
                var tmp_BlockFullName = typeof(ImmersalBlock).FullName;
                if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                    ConvertToBlock(tmp_BlockFullName);
            }


            if (editingDetailData.Configures.Algorithm != AlgorithmType.FaceMesh)
            {
                var tmp_BlockFullName = typeof(FaceMeshBlock).FullName;
                if (editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                {
                    RemoveBlock(tmp_BlockFullName);
                }
            }

            if (editingDetailData.Configures.Algorithm == AlgorithmType.FaceMesh)
            {
                var tmp_BlockFullName = typeof(FaceMeshBlock).FullName;
                if (!editingDetailData.GetBlock.Contains(tmp_BlockFullName))
                    ConvertToBlock(tmp_BlockFullName);
            }
        }

        private void RightClickedMenu()
        {
            var tmp_MenuContext = new GenericMenu();
            for (int tmp_MenuIdx = 0; tmp_MenuIdx < menuList.Count; tmp_MenuIdx++)
            {
                var tmp_Idx = tmp_MenuIdx;
                tmp_MenuContext.AddItem(new GUIContent(menuList[tmp_MenuIdx]), false,
                    () => ConvertToBlock($"{CONST_SCRIPT_NAME_SPACE}{blocks[tmp_Idx]}"));
            }

            tmp_MenuContext.ShowAsContext();
        }


        /// <summary>
        /// Use the name of the block to convert the corresponding block object.
        /// </summary>
        /// <param name="_blockType">name of the block</param>
        private void ConvertToBlock(string _blockType)
        {
            var tmp_Block = BlockFactory.CreateBlock(_blockType, editingDetailData.Configures);
            if (AddBlock(tmp_Block))
            {
                CachingBlockCol(tmp_Block);
            }
            else
            {
                EditorUtility.DisplayDialog("Error!", "The block already exists, please do not add it repeatedly.",
                    "Ok");
            }
        }

        protected override void Dispose(bool disposeManaged)
        {
            base.Dispose(disposeManaged);
            EditorUtility.SetDirty(editingDetailData.Configures);
        }
    }
}