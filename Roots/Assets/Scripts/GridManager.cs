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
    [SerializeField]
    private GameObject tileType;
	[SerializeField]
	private bool hasStartingArea = false;


	void Start()
    {
        GenerateGrid();
        if(hasStartingArea) GenerateStartingArea();
    }

    private void GenerateGrid()
    {
        for(int row=0; row < rows; row++)
        {
            for(int col =0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(tileType, transform);
                float posX = col * tileSize;
                float posY = row * -tileSize;
                tile.name = $"{tileType.name}_{posX}_{posY}";

                tile.transform.position = new Vector2(posX, posY);

            }
        }

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW/2 + tileSize /2, gridH/2 - tileSize /2);

    }

    private void GenerateStartingArea()
    {
		for (int x = 30; x != 33; x++)
			for (int y = 29; y != 34; y++)
				Destroy(GameObject.Find($"{tileType.name}_{x}_-{y}"));
		for (int y = 30; y != 33; y++)
			Destroy(GameObject.Find($"{tileType.name}_29_-{y}"));
		for (int y = 30; y != 33; y++)
			Destroy(GameObject.Find($"{tileType.name}_33_-{y}"));
	}
}
