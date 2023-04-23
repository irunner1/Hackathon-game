using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public Sprite opened;
    private SpriteRenderer spriteRenderer;
    public bool isOpened = false;
    public bool isEmpty = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (col.gameObject.TryGetComponent<Player_>(out Player_ comp_key))
            {
                if(comp_key.isKey && !isEmpty)
                {
                    isOpened = true;
                    isEmpty = true;
                    comp_key.Block_amount += 20;
                    changeSprite();
                }
            }
            // 
            // Тут нужно вписать скрипт после решения головоломки
            // 
            // if (isOpened && !isEmpty)
            // {
            //     if (col.gameObject.TryGetComponent<Player_>(out Player_ comp))
            //     {
            //         comp.Block_amount += 20;
            //         isEmpty = true;
            //         changeSprite();
            //     }
            // }
        }
    }

    private void changeSprite()
    {
        if (isEmpty && isOpened)
        {
            spriteRenderer.sprite = opened;
        }
    }
}
