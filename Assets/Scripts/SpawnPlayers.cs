using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UIElements;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public Vector2 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(player.name, spawnPosition, Quaternion.identity);
    }
   
}
