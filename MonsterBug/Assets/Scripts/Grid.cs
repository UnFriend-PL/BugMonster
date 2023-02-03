using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private int gridWidth, gridHeight;
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Transform cam;

	private void Start()
	{
		GenerateGrid();
	}   

	void GenerateGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x},{y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }

        cam.transform.position = new Vector3((float)gridWidth/2 -0.5f, (float)gridHeight/2 -0.5f, -10);
    }
}
