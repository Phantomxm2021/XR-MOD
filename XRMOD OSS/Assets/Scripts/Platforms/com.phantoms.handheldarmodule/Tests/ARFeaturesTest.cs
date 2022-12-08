#if HANDHELD_ARMODULE_INSTALL
using System;
using System.Collections;
using com.phantoms.models.Runtime;
using HandheldARModule.Runtime;
using HandheldARModule.Runtime.Extension;
using HandheldARModule.Runtime.FeaturesDecorator;
using HandheldARModule.Runtime.Models;
using NUnit.Framework;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.XR.ARFoundation;
using XRMODEngineCore.Runtime;
using Object = UnityEngine.Object;

namespace HandheldARModule.Tests
{
    public class ARFeaturesTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ARFeaturesTestSimplePasses()
        {
            // Use the Assert class to test conditions
            var tmp_ConfigureJson = Resources.Load<TextAsset>("Configure");
            Assert.IsNotEmpty(tmp_ConfigureJson.text);

            var tmp_ARSession = Object.Instantiate(Resources.Load<GameObject>("Prefabs/AR Session"));
            var tmp_ARSessionOrigin = Object.Instantiate(Resources.Load<GameObject>("Prefabs/AR Session Origin"));

            Runtime.HandheldARModule tmp_Module = new Runtime.HandheldARModule();
            var tmp_ArModel = IocContainer.GetIoc.Resolve<RuntimeProjectConfig>();
            Assert.IsNotNull(tmp_ArModel);

            tmp_Module.StartModule();

            tmp_ArModel.CurrentConfigures.Value = JsonUtility.FromJson<ARConfiguresModel>(tmp_ConfigureJson.text);

            tmp_ArModel.CurrentConfigures.OnValueChanged += _configures =>
            {
                switch (_configures.Algorithm)
                {
                    case AlgorithmType.FocusSlam:
                        Assert.IsNotNull(GameObject.FindObjectOfType<FocusPlacementExtension>());
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<FocusSlamDecorator>());
                        Assert.IsNull(GameObject.FindObjectOfType<FocusPlacementExtension>());
                        break;
                    case AlgorithmType.Anchor:
                        Assert.IsNotNull(GameObject.FindObjectOfType<AnchorManagerExtension>());
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<AnchorCreatorDecorator>());
                        Assert.IsNull(GameObject.FindObjectOfType<AnchorManagerExtension>());
                        break;
                    case AlgorithmType.Gyro:
                        Assert.IsTrue(IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.currentTrackingMode ==
                                      TrackingMode.RotationOnly);
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<ThreeDofDecorator>());
                        Assert.IsTrue(IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.currentTrackingMode ==
                                      TrackingMode.DontCare);
                        break;
                    case AlgorithmType.Fixed:
                        Assert.IsTrue(IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.currentTrackingMode ==
                                      TrackingMode.DontCare);
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<FixedDecorator>());
                        Assert.IsTrue(IocContainer.GetIoc.Resolve<ARComponentModel>().ARSession.currentTrackingMode ==
                                      TrackingMode.PositionAndRotation);
                        break;
                    case AlgorithmType.ImageTracker:
                        var tmp_ARTracked = GameObject.FindObjectOfType<ARTrackedImageManager>();
                        Assert.IsNotNull(tmp_ARTracked);
                        Assert.IsNull(tmp_ARTracked.referenceLibrary == null);
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<ImageTrackDecorator>());
                        Assert.IsNull(GameObject.FindObjectOfType<ARTrackedImageManager>());
                        break;
                    case AlgorithmType.Immersal:
                        break;
                    case AlgorithmType.FaceMesh:
                        Assert.IsNotNull(GameObject.FindObjectOfType<ARFaceManager>());
                        tmp_Module.StopModule();
                        Assert.IsNull(IocContainer.GetIoc.Resolve<FaceMeshDecorator>());
                        Assert.IsNull(GameObject.FindObjectOfType<ARFaceManager>());
                        break;
                    case AlgorithmType.Classic3D:
                        Assert.IsNull(GameObject.FindObjectOfType<ARSession>());
#if ARFOUDATION_4_0_0
                        Assert.IsNull(GameObject.FindObjectOfType<ARSessionOrigin>());
#else
                        Assert.IsNull(GameObject.FindObjectOfType<XROrigin>());
#endif
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                ;


                Object.DestroyImmediate(tmp_ARSession);
                Object.DestroyImmediate(tmp_ARSessionOrigin);
            };
        }

        // A UnityTest allows `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        // A test with the [RequiresPlayMode] tag ensures that the test is always run inside PlayMode.
        [UnityTest]
        public IEnumerator NewTestScriptInPlayModeWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
#endif