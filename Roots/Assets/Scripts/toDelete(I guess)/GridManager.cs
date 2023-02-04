using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int rows = 32;
    [SerializeField]
    private int cols = 32;
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
		//for (int x = 30; x != 33; x++)
        for (int x = (rows / 2) - 2; x != (rows / 2) + 1; x++)
			for (int y = (cols / 2) - 3; y != (cols / 2) + 2; y++)
				Destroy(GameObject.Find($"{tileType.name}_{y}_-{x}"));
		for (int y = (cols / 2) - 2; y != (cols / 2) + 1; y++)
			Destroy(GameObject.Find($"{tileType.name}_{y}_-{(rows / 2) - 3}"));
		for (int y = (cols / 2) - 2; y != (cols / 2) + 1; y++)
			Destroy(GameObject.Find($"{tileType.name}_{y}_-{(rows / 2) + 1}"));
	}
}
