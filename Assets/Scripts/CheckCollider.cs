using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cainos.PixelArtTopDown_Basic;

public class CheckCollider : MonoBehaviour {
    public static CheckCollider Instance { get; private set; }
     private void Awake() {
        Instance = this;
    }


    public bool isInTrigger = false;

    [SerializeField] string Scene;

    private void OnTriggerEnter2D(Collider2D other) {
        isInTrigger = true;
        SceneManager.UnloadSceneAsync(Scene);
        GetComponent<TopDownCharacterController>().enabled = false;
    }
}
