using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsMining : MonoBehaviour
{
    [SerializeField] private GameObject value;
    //[SerializeField] private GameObject value;
   // [SerializeField] private string EatTag = "Food";
    [SerializeField] private string MineTag = "Block";

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == MineTag) {
            if (collision.gameObject.GetComponent<Block>().Mine())
                {
                    value.GetComponent<ScoreManager>().countOfDirt++;
                    value.GetComponent<ScoreManager>().Start();
                }
        }
    
    }
}
