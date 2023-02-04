using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecTile : MonoBehaviour
{
    public static event Action<Vector3> selectedTile;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = -1;
            selectedTile?.Invoke(targetPos);
        }
    }
}
