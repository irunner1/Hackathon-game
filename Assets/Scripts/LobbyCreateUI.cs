using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LobbyCreateUI : MonoBehaviour {

    public static LobbyCreateUI Instance { get; private set; }

    [SerializeField] private Button createButton;
    [SerializeField] private Button lobbyNameButton;
    [SerializeField] private Button publicPrivateButton;
    [SerializeField] private Button maxPlayersButton;
    [SerializeField] private Button gameModeButton;

    private string lobbyName;
    private bool isPrivate;
    private int maxPlayers;
    // private LobbyManager.GameMode gameMode;

    private void Awake() {
        
        createButton.onClick.AddListener(() => {
            // LobbyManager.Instance.CreateLobby(
            //     lobbyName,
            //     maxPlayers,
            //     isPrivate,
            //     gameMode
            // );
            // Hide();
        });
    }

    void Start() {
        
    }

    void Update() {
        
    }
}
