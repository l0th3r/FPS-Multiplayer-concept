using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ClientPawn : NetworkBehaviour
{
    [SerializeField] private NetworkIdentity identity;

    [SerializeField]
    public GameObject localElements, remoteElements, serverElements, sharedElements;

    private void Start()
    {
        if(isLocalPlayer)
        {
            remoteElements.SetActive(false);
        }
        else
        {
            localElements.SetActive(false);
        }
    }
}
