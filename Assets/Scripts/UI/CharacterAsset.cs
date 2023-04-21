using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAsset : MonoBehaviour {
    public static CharacterAsset Instance { get; private set; }

    [SerializeField] private Sprite hunterSprite;
    [SerializeField] private Sprite runnerSprite;

    private void Awake() {
        Instance = this;
    }

    public Sprite GetSprite(LobbyManager.PlayerCharacter playerCharacter) {
        switch (playerCharacter) {
            default:
            case LobbyManager.PlayerCharacter.Hunter:   return hunterSprite;
            case LobbyManager.PlayerCharacter.Runner:    return runnerSprite;
        }
    }

}