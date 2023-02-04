using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnt : MonoBehaviour
{
    public int HP;

    // Update is called once per frame
    private int counter = 0;
    Vector3 firstPos, secondPos;
    public float speed = 0.5f;
    private Vector3 direction;

    void Start()
    {
        SelecTile.selectedTile += OnTileSelected;

    }

    private void Update()
    {
        //StartCoroutine(MoveToPosition(secondPos));
        transform.position = Vector3.Lerp(transform.position, secondPos, speed * Time.deltaTime);

    }

    private void OnDestroy()
    {
        SelecTile.selectedTile -= OnTileSelected;
    }
    private void OnTileSelected(Vector3 obj)
    {
        if (obj == firstPos)
        {
            return;
        }
        Debug.Log($"{obj} - tile");

        secondPos = obj;
    }

    IEnumerator MoveToPosition(Vector3 targetPos)
    {
        while (Vector3.Distance(transform.position, targetPos) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
    }


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = transform.position;
            firstPos = position;
            Debug.Log($"{position} - ant");
            //if (counter == 0)
            //{
            //    firstPos = position;
            //    counter += 1;
            //    Debug.Log(position);
            //}
            //if (counter == 1)
            //{
            //    secondPos = position;
            //    counter = 0;
            //}
            //if (counter > 0 && Input.GetMouseButtonDown(0))
            //{
            //    counter = 0;
            //}
        }
    }
}
