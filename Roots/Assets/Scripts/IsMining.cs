using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMining : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetObject<Block>().type = blockType.Background;
        Debug.Log(transform.position);
    }
}
