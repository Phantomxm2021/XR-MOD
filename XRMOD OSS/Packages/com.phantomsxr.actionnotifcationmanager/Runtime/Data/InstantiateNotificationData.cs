using com.Phantoms.ActionNotification.Runtime;
using UnityEngine;

namespace com.Phantoms.ActionNotification.Runtime
{
    public class InstantiateNotificationData:BaseNotificationData
    {
        public GameObject Prefab;
        public Transform Parent;
        public Vector3 Position;
        public Quaternion Rotation;
    }
}