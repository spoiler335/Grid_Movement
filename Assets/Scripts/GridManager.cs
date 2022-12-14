using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] int rows;
    [SerializeField] int columns;

    [SerializeField] float tileSize =1;

    [SerializeField] GameObject referenceTile;

    void Start()
    {
        generateGrid();   
    }

    
    void generateGrid()
    {
        
        for(int i=0; i < rows; i++)
        {
            for(int j=0; j < columns; j++)
            {
                GameObject tile = (GameObject) Instantiate(referenceTile, transform);
                var s= tile.GetComponent<SpriteRenderer>();
                float r= Random.Range(0.0f, 1.0f);
                s.color = new Color(r, r, r);
                float posx = j * tileSize;
                float posy = i * -tileSize;
                tile.transform.position = new Vector3(posx, posy);
            }
        }

        float gridW = columns * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(  (-gridW/2 + tileSize) , (gridH/2 + tileSize) );
        

    }

    
 
}
