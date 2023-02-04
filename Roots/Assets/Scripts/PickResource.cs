using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickResource : MonoBehaviour
{

    [SerializeField] private string chosenTag;
    [SerializeField] private ScoreManager scoreManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == chosenTag)
        {
            scoreManager.countOfFood++;
            Destroy(collision.gameObject);
        }
        Debug.Log(scoreManager.countOfFood + " pkt");
    }
}
