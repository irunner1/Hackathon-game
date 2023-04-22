using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;

    [SerializeField] Vector2 moveDirection;

    private void FixedIpdate() {
        
        if (Input.GetKey(keyOne)) {
            GetComponent<Rigidbody2D>().velocity += moveDirection;
        }
        
        if (Input.GetKey(keyTwo)) {
            GetComponent<Rigidbody2D>().velocity -= moveDirection;
        }

    }
}
