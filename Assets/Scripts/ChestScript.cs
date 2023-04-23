using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
using Cainos.PixelArtTopDown_Basic;
// using Unity.Services.Lobbies.Models;

public class ChestScript : MonoBehaviour
{
    public Sprite opened;
    private SpriteRenderer spriteRenderer;
    public bool isOpened = false;
    public bool isEmpty = false;
    public bool isInTrigger = false;
    public bool canOpen = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public enum Scenes {
        Scene_test_game,
        Scene_quest1,
        Scene_quest2,
        Scene_quest3
    }

    // private void OnTriggerEnter(Collider other) {
    //     NetworkObject networkObject = other.GetComponent<NetworkObject>();
    //     if (networkObject != null) {
    //         int tmp_num = UnityEngine.Random.Range(0, 3);
    //         string str = ((Scenes) tmp_num).ToString();

    //         LoadScene(networkObject, str);
    //     }
    // }

    public static void LoadScene(NetworkObject networkObject, string scene) {
        if (!networkObject) {
            return;
        }

        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Scene_test_game");
    }

    private void Update()
    {
        if (isInTrigger)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (canOpen)
                {
                    changeSprite();
                    isOpened = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInTrigger = true;
        if (!isOpened)
        {
            if (other.gameObject.TryGetComponent<Player_>(out Player_ comp))
            {
                if (comp.isKey)
                {
                    canOpen = true;
                }
            }
        }
        NetworkObject networkObject = other.GetComponent<NetworkObject>();
        if (networkObject != null) {
            int tmp_num = UnityEngine.Random.Range(0, 3);
            string str = ((Scenes) tmp_num).ToString();
            Debug.Log(str);
            LoadScene(networkObject, str);
            other.gameObject.GetComponent<TopDownCharacterController>().enabled = false;
        }
        if (GetComponent<CheckCollider>().isInTrigger == true) {
            other.gameObject.GetComponent<TopDownCharacterController>().enabled = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(isOpened)
        {
            if (other.gameObject.TryGetComponent<Player_>(out Player_ comp))
            {
                comp.isKey = false;
            }
        }
        isInTrigger = false;
    }
    private void changeSprite()
    {
        if (isOpened)
        {
            spriteRenderer.sprite = opened;
        }
    }
}
