using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerNetwork : NetworkBehaviour {
    private readonly NetworkVariable<Vector3> _netPos = new(writePerm: NetworkVariableWritePermission.Owner);
    private readonly NetworkVariable<Quaternion> _netRot = new(writePerm: NetworkVariableWritePermission.Owner);

    void Update() {
        if (IsOwner) {
            _netPos.Value = transform.position;
            _netRot.Value = transform.rotation;
        }
        else {
            transform.position = _netPos.Value;
            transform.rotation = _netRot.Value;
        }
    }

    struct PlayerNetworkData : INetworkSerializable {
        private float _x, _z;

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
        {
            throw new System.NotImplementedException();
        }
    }
}
