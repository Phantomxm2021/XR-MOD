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

using UnityEngine;

namespace Mirror
{
    public static class NetworkIdentityExtension
    {
        public static void IdentityStart(this NetworkIdentity _identity)
        {
            if (!NetworkServer.active) return;
            var tmp_OwnerConnection = NetworkClient.connection.identity.connectionToClient;
            _identity.connectionToClient = tmp_OwnerConnection;

            // special case to make sure hasAuthority is set
            // on start server in host mode
            if (tmp_OwnerConnection is LocalConnectionToClient)
                _identity.hasAuthority = true;
            
            _identity.OnStartServer();
        }
    }
}