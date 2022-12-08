using Mirror;

namespace com.PhantomsXR.MirrorExtension.Runtime
{
    public struct AssignClientAuthorityMessage:NetworkMessage
    {
        public NetworkIdentity AssignedObject;
        public NetworkIdentity ObjectToBeAllocated;


    }
}