using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTile : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
