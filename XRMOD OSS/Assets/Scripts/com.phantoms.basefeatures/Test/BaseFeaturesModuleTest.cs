// using com.Phantoms.ActionNotification.Runtime;
// using com.phantoms.BaseFeatures.Runtime;
// using com.phantoms.BaseFeatures.Runtime.Models;
using NUnit.Framework;
// using UnityEngine;
// using XRMODEngineCore.Runtime;

public class BaseFeaturesModuleTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void BaseFeaturesModuleTestSimplePasses()
    {
        // Use the Assert class to test conditions
        // IocContainer.GetIoc.Register(new BaseFeatureModel());
        // ICommand tmp_Command = new BuildNetworkMeshDownloadCommand();
        // tmp_Command.Execute();
        //
        // ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.DownloadMesh),
        //     new BaseNotificationData()
        //     {
        //         BaseData =
        //             "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/BoxAnimated/glTF-Binary/BoxAnimated.glb?t=1223",
        //         NotificationActWithData = _o => { Debug.Log(_o as string); }
        //     });
        // IocContainer.GetIoc.UnRegister<BaseFeatureModel>();
        // ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.DownloadMesh));
    }
    //
    // // A UnityTest allows `yield return null;` to skip a frame.
    // [UnityTest]
    // public IEnumerator NewTestScriptWithEnumeratorPasses()
    // {
    //     // Use the Assert class to test conditions.
    //     // Use yield to skip a frame.
    //     yield return null;
    // }
    //
    // // A test with the [RequiresPlayMode] tag ensures that the test is always run inside PlayMode.
    // [UnityTest]
    // [RequiresPlayMode]
    // public IEnumerator NewTestScriptInPlayModeWithEnumeratorPasses()
    // {
    //     // Use the Assert class to test conditions.
    //     // Use yield to skip a frame.
    //     yield return null;
    // }
}