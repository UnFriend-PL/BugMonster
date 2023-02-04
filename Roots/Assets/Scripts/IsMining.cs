using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsMining : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<Block>().Mine();

        Vector2 position = Vector2.zero;
        var colliders = Physics.OverlapBox(position, Vector3.one * 1.5f);


        foreach (Collider col in colliders)
        {
            if (col.TryGetComponent<Block>(out var tile))
            {
               tile.isFoggy = false; 
            }
        }
    }
}
