using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour
{
    public float damage;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Player_>(out Player_ playerComponent))
        {
            playerComponent.takeDamage(damage);
        }
    }

}
