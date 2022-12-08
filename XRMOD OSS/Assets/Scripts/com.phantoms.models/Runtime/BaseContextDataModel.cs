// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using com.Phantoms.ILRuntime.Runtime;
using UnityEngine;
using XRMODEngineCore.Runtime;

namespace com.phantoms.models.Runtime
{
    public class BaseContextDataModel : IModel, IReleaseCommand
    {
        public Camera MainCamera;

        public BindableProperty<CodesHook> CodeHook { get; private set; }

        public GameObject MultiplayerGo { get; set; }

        public GameObject RecorderGo { get; set; }

        public GameObject ConsoleGo;

        public GameObject VisualScriptingGo;

        public Vector2Int PhotoSize;

        public GameObject XRFrameGrabber { get; set; }

        public string ProjectUid;
        public ProjectInfoData ProjectInfo { get; set; }

        public class ProjectInfoData
        {
            public string ProjectUid;
            public string AppUid;
            public string UserUid;
            public string Platform;
        }

        public BaseContextDataModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            CleanAlreadyGameObject();

            PhotoSize = Vector2Int.zero;
            ProjectInfo = null;
            ProjectUid = null;
            CodeHook = new BindableProperty<CodesHook>();
        }


        public void Release()
        {
            CleanAlreadyGameObject();

            // Release last, otherwise some resources cannot be released correctly
            // if (CodeHook.Value != null)
            // {
            //     CodeHook.Value.Dispose();
            //     CodeHook.Value = null;
            // }
        }

        private void CleanAlreadyGameObject()
        {
            if (ConsoleGo)
                ConsoleGo.DestroyWithPlatform();

            if (RecorderGo)
                RecorderGo.DestroyWithPlatform();

            if (VisualScriptingGo)
                VisualScriptingGo.DestroyWithPlatform();

            if (XRFrameGrabber)
                XRFrameGrabber.DestroyWithPlatform();

            if (MultiplayerGo)
                MultiplayerGo.DestroyWithPlatform();
        }
    }
}