using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickResource : MonoBehaviour
{

    [SerializeField] private string chosenTag;
    [SerializeField] private GameObject value;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == chosenTag)
        {
            value.GetComponent<ScoreManager>().countOfDirt++;
            Destroy(collision.gameObject);
            value.GetComponent<ScoreManager>().Start();
        }
    }

    private enum foodType {
        leaf,
        blueberry,
        larva,
        food
    }
}
