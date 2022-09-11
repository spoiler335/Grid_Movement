using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] Sprite sprite;
    float[,] a;
    int vertical,horizontal,columns,rows;

    void Start()
    {
        vertical = (int) Camera.main.orthographicSize;
        horizontal = vertical - (Screen.width / Screen.height);
        columns = horizontal * 2;
        rows = vertical * 2;
        a = new float[columns,rows];
        for(int i = 0; i < columns; ++i)
        {
            for(int j = 0; j < rows; ++j)
            {
                a[i, j] = Random.Range(0f,1f);
                generateGrid(i,j,a[i,j]);
            }
        }
    }

    
    void generateGrid(int x, int y, float value)
    {
        GameObject g = new GameObject("x"+x+"y"+y);
        g.transform.position = new Vector3(x-(horizontal-0.5f),y-(vertical-0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(value,value,value);

    }

    
 
}
