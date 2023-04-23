using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    Red,
    Green,
    Blue,
    Yellow,
    Magenta,
    White,
    Orange,
    Cyan
}

public class Tile : MonoBehaviour
{

    private TileType type;

    private static Color[] ColorLookup = 
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.white,
        new Color(1.0f, 0.5f, 0.0f),
        Color.cyan,
    };
    
    public void Init(TileType type)
    {
        this.type = type;
        GetComponent<SpriteRenderer>().color = ColorLookup[(int)type];
    }
}
