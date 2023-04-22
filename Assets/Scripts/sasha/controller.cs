using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controller : MonoBehaviour
{
    private float vertical; 
    private float horizontal; 
    private Rigidbody2D rb; 
    [SerializeField] private float speed = 5; 
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal") * speed;

        vertical = Input.GetAxis("Vertical") * speed;

        rb.velocity = new Vector2(horizontal, vertical);

    }

    
}
