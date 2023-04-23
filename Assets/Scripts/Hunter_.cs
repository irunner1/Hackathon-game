using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Hunter_ : MonoBehaviour
{
    public float damage;

    public float attackTimer;
    public float attackCooldown;
    public LayerMask player_mask;

    void Start()
    {

    }

    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if (attackTimer <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, 1.25f, player_mask);

                foreach (var hitCollider in hitColliders)
                {
                    // Debug.Log("ouch");
                    hitColliders[0].GetComponent<Player_>().takeDamage(damage);
                }
                attackTimer = attackCooldown;
                TopDownCharacterController.speed = 0.5f;
                Invoke(nameof(increase_speed), 1.0f);
            }
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }
    }

    public void increase_speed()
    {
        TopDownCharacterController.speed = 3.0f;
    }
}
