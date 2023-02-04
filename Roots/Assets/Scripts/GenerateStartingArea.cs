using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStartingArea : MonoBehaviour
{
    void Start()
    {
		for (int x = 62; x != 64; x++)
			for (int y = 29; y != 33; y++)
				Destroy(GameObject.Find($"Dirt_{x}_{y}"));
		for (int y = 30; y != 32; y++)
			Destroy(GameObject.Find($"Dirt_61_{y}"));
		for (int y = 30; y != 32; y++)
			Destroy(GameObject.Find($"Dirt_65_{y}"));

	}
}
