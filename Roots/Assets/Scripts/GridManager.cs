using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int rows = 10;
    [SerializeField]
    private int cols = 16;
    [SerializeField]
    private float tileSize = 1;


    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("Dirt"));
        for(int row=0; row < rows; row++)
        {
            for(int col =0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);
                float posX = col * tileSize;
                float posY = row * -tileSize;
                tile.name = $"Dirt_{posX}_{posY}";

                tile.transform.position = new Vector2(posX, posY);

            }
        }
        Destroy(referenceTile);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW/2 + tileSize /2, gridH/2 - tileSize /2);

    }
    private Color startcolor;
    void OnMouseEnter()
    {
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
