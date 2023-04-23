using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField] private float tileSpacing = 1.5f;
    [SerializeField] private int noTiles = 4;
    [SerializeField] private float start = -3.0f;
    [SerializeField] private Tile tilePrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        List<TileType> tiles = new List<TileType>();
        float y = start;

        for (int i = 0; i < noTiles; i++) {
            float x = start;
            for (int j = 0; j < noTiles; j++) {
                Tile tile = Instantiate<Tile>(tilePrefab, new Vector3(x, y), Quaternion.identity);

                TileType type = new TileType();
                do
                    type = (TileType)Random.Range(0, 8);
                 while (tiles.GetItemCount(type) >= 2);
                tiles.Add(type);
                tile.Init(type);
                x += tileSpacing;
            }
            y += tileSpacing;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
