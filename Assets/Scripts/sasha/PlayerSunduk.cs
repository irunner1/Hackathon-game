using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSunduk : MonoBehaviour
{
    public float speed = 0.1f;

    private void Update() {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");
        // transform.position += new Vector3(0, speed, 0) * Input.GetAxis("Vertical");
    }
    private void OnTriggerEnter (Collider other) {
        if (this.CompareTag("Player") && other.CompareTag("Finish")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
