using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;


public class CustomManager : MonoBehaviour {

    [SerializeField] public GameObject runnerPrefab;
    [SerializeField] public GameObject hunterPrefab;
    private string asd;
    private Player player;

    public void Start() {
        // Debug.Log(player.Data[LobbyManager.KEY_PLAYER_NAME].Value);
        Debug.Log(LobbyManager.Instance.GetPlayer());
        player = LobbyManager.Instance.GetPlayer();
        // player.AllocationId;
        NetworkManager.Singleton.OnServerStarted += spawnPlayer;
        GameObject go = Instantiate(runnerPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponent<NetworkObject>().Spawn();
    }

    public void spawnPlayer() {
        NetworkManager.Singleton.OnServerStarted -= spawnPlayer;
        // NetworkManager.
    }
}
