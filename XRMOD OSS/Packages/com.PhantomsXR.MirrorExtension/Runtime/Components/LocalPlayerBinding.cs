using Mirror;
using UnityEngine;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class LocalPlayerBinding : NetworkBehaviour
    {
        [SyncVar] public string bindingPlayerName;

        private GameObject localPlayerGameObject;

        public void BindingPlayerGameObject(string _customPlayerName)
        {
            bindingPlayerName = _customPlayerName;
        }

        public void GetCustomLocalPlayer(out GameObject _customPlayer)
        {
            if (localPlayerGameObject == null)
                localPlayerGameObject = GameObject.Find(bindingPlayerName);
            _customPlayer = localPlayerGameObject;
        }
    }
}