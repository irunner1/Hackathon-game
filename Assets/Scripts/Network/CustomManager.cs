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
    public static CustomManager Instance { get; private set; }

    [SerializeField] public GameObject runnerPrefab;
    [SerializeField] public GameObject hunterPrefab;
    private string asd;
    private Player player;

    public void Awake() {
        Instance = this;
        // Debug.Log(player.Data["Character"].Value);
        // // options.Data[KEY_PLAYER_CHARACTER].Value
        // Debug.Log(LobbyManager.Instance.GetPlayer());

        // player = LobbyManager.Instance.GetPlayer();
        // foreach (Player player in lobby.Players) {
        //     Debug.Log(player.Id + " " + player.Data["Playername"].Value);
        // }

        // player.AllocationId;
        // GameObject go = Instantiate(runnerPrefab, Vector3.zero, Quaternion.identity);
        // go.GetComponent<NetworkObject>().Spawn();
    }

    public void spawnPlayer(Lobby lobby) {
        foreach (Player player in lobby.Players) {
            Debug.Log(player.Id + " " + player.Data["Playername"].Value);
        }
        GameObject go = Instantiate(runnerPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponent<NetworkObject>().Spawn();
    }
}
