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

using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class RealtimeSyncTransform : NetworkBehaviour
    {
        // ReSharper disable once InconsistentNaming
        [SerializeField] private Transform self;

        private void Awake()
        {
            self = transform;
        }

        private void Update()
        {
            if (hasAuthority)
            {
                CmdModifyThePose(self.localPosition, self.localRotation);
            }
        }

        [Command]
        private void CmdModifyThePose(Vector3 _syncedPos, Quaternion _syncedRot)
        {
            RpcSynchronizePos(_syncedPos, _syncedRot);
        }

        [ClientRpc]
        private void RpcSynchronizePos(Vector3 _syncedPos, Quaternion _syncedRot)
        {
            if (hasAuthority) return;
            self.localPosition = _syncedPos;
            self.localRotation = _syncedRot;
        }
    }
}