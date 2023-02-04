using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecTile : MonoBehaviour
{
    public static event Action<Vector2> selectedTile;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedTile?.Invoke(targetPos);
        }
    }
}
