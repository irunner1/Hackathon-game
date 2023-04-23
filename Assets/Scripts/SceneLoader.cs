using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class SceneLoader : MonoBehaviour
{
    public enum Scenes {
        Scene_test_game,
        Scene_quest1,
        Scene_quest2,
        Scene_quest3
    }

    private void OnTriggerEnter(Collider other) {
        NetworkObject networkObject = other.GetComponent<NetworkObject>();
        if (networkObject != null) {
            int tmp_num = UnityEngine.Random.Range(0, 3);
            string str = ((Scenes) tmp_num).ToString();

            LoadScene(networkObject, str);
        }
    }

    public static void LoadScene(NetworkObject networkObject, string scene) {
        if (!networkObject) {
            return;
        }

        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }

}
