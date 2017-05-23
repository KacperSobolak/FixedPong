using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PozycjaPlaformy : NetworkBehaviour {

    public float PositionLerpSpeed = 10.0F;

    [SyncVar]
    Vector3 position;

    void Start () {
		
	}
	
	void Update () {
		
	}

    [ClientCallback]
    void TransmitData()
    {
        if (isLocalPlayer)
        {
            CmdSyncData(transform.position);
        }
    }

    void RecieveData()
    {
        if (!isLocalPlayer)
        {
            transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * PositionLerpSpeed);
        }
    }

    [Command]
    void CmdSyncData(Vector3 pos)
    {
        position = pos;
    }
}
