using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnt : MonoBehaviour
{
    public int HP;

    Vector3 firstPos, secondPos;
    public float speed = 0.5f;

    void Start()
    {
        SelecTile.selectedTile += OnTileSelected;

    }

    private void FixedUpdate()
    {
        var body = GetComponent<Rigidbody2D>();
        body.MovePosition(Vector2.Lerp(body.position,secondPos,speed*Time.fixedDeltaTime));


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

        Vector3 direction = new Vector3(
            secondPos.x - transform.position.x,
            secondPos.y - transform.position.y,
            secondPos.z - transform.position.z);
        transform.up = direction;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = transform.position;
            firstPos = position;
            Debug.Log($"{position} - ant");
        }
    }
}
