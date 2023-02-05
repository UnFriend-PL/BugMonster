using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsMining : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<Block>().Mine())
        {

        }
    }
}
