using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grob : MonoBehaviour
{
    public float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Input.GetAxis("Vertical");
    }
    
}
