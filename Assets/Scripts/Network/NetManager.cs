using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetManager : NetworkManager
{
    // New connection event
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        Transform startPos = GetStartPosition();

        GameObject player = startPos != null
                ? Instantiate(playerPrefab, startPos.position, startPos.rotation)
                : Instantiate(playerPrefab);

        player.name = $"{playerPrefab.name} [id={conn.connectionId}]";

        // Enable on server only
        //DisableNonServerElementsOnClient(player.GetComponent<ClientPawn>());
        
        NetworkServer.AddPlayerForConnection(conn, player);
    }


    private void DisableNonServerElementsOnClient(ClientPawn cpawn)
    {
        cpawn.localElements.SetActive(false);
        cpawn.remoteElements.SetActive(false);
        cpawn.sharedElements.SetActive(false);
    }

}
