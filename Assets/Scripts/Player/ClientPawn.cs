using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ClientPawn : NetworkBehaviour
{
    [SyncVar]
    private List<ClientPawn> m_pawns;
}
