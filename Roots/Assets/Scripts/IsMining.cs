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
        if (collision.gameObject.tag == MineTag)
        {
            if (collision.gameObject.GetComponent<Block>().Mine())
            {
                value.GetComponent<ScoreManager>().countOfDirt++;
                value.GetComponent<ScoreManager>().Start();
            }
        }

        //void OnCollisionEnter2D(Collision2D coll)
        //{
        //    Debug.Log($"collision! with {coll.gameObject.tag}");
        //    if (coll.gameObject.tag == "Block" || coll.gameObject.tag == "Food")
        //    {
        //        coll.gameObject.GetComponent<Block>().Mine();
        //    }
            //if(coll.gameObject.tag == "Bug")
            //{
            //    //coll.gameObject.GetComponent<SelectAnt>().HP--;
            //    //var bugHp = coll.gameObject.GetComponent<Bug>().HP;
            //    //coll.gameObject.GetComponent<SelectAnt>().HP -= 1;
            //    //if(coll.gameObject.GetComponent<SelectAnt>().HP <= 0)
            //    //{
            //    SelectAnt selectAnt = GetComponent<SelectAnt>();
            //    if (selectAnt != null)
            //    {
            //        Debug.Log("Ant should be destroyed");
            //        Destroy(gameObject);
            //        //MonoBehaviour[] scripts = coll.gameObject.GetComponents<MonoBehaviour>();
            //        //foreach (MonoBehaviour script in scripts)
            //        //{
            //        //    DestroyImmediate(script);
            //        //}
            //        //DestroyImmediate(coll.gameObject);
            //    }
            //    //    }
            //    //    if(coll.gameObject.GetComponent<Bug>().HP > 0)
            //    //    {
            //    //        coll.gameObject.GetComponent<Bug>().HP -= 1;
            //    //    }
            //    //    else if(coll.gameObject.GetComponent<Bug>().HP <= 0)
            //    //    {
            //    //        Destroy(coll.gameObject.GetComponent<Bug>());
            //    //    }
            //    //    Debug.Log($"{coll.gameObject.GetComponent<SelectAnt>().HP} - ANT HP");
            //}
        //}
    }
}
