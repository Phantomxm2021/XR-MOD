using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using com.Phantoms.ActionNotification.Runtime;
using com.Phantoms.ARMODAPI.Runtime;

namespace com.Phantoms.ARMODAPI.Tests
{
    public class armodapi_Tests_Runtime_NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public async void LoadAssetFromEditor()
        {
            API tmp_API = new API("VSAnchorDemo");
            var tmp_Go = await tmp_API.LoadAssetAsync<GameObject>("Sphere");
            Assert.IsNotNull(tmp_Go);
        }

        [Test]
        public void GetCurrentFrameTest()
        {
#if HANDHELD_ARMODULE_INSTALL
            // Use the Assert class to test conditions
            ActionNotificationCenter.DefaultCenter.AddObserver(GetTextureTest,
                nameof(ActionParameterDataType.TryAcquireCurrentFrame));

            API tmp_Api = new API("");
            var tmp_CurrentFrame = tmp_Api.TryAcquireCurrentFrame(new TryAcquireCurrentFrameNotificationData()
                {AcquiredTextureFormat = TextureFormat.R8});
            Assert.AreNotEqual(tmp_CurrentFrame, null);
            var tmp_JPGBytes = tmp_CurrentFrame.EncodeToJPG();
            File.WriteAllBytes(Path.Combine(Application.dataPath, "test.jpg"), tmp_JPGBytes);
#endif
        }

        private object GetTextureTest(BaseNotificationData _obj)
        {
            return new Texture2D(100, 100, TextureFormat.RGB24, false);
        }
    }
}