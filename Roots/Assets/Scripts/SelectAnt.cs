using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnt : MonoBehaviour
{
    //public int HP;
    bool isSelected = false;

    Vector3 firstPos, secondPos;
    public float speed = 0.5f;
	[SerializeField] private SpriteRenderer renderer;
	[SerializeField] private Color hightlightColor = new Color(0.5f, 0, 0, 1);

	void Start()
    {
        SelecTile.selectedTile += OnTileSelected;
    }

    private void FixedUpdate()
    {
			var body = GetComponent<Rigidbody2D>();
			body.MovePosition(Vector2.Lerp(body.position, secondPos, speed * Time.fixedDeltaTime));
    }

    private void OnDestroy()
    {
        SelecTile.selectedTile -= OnTileSelected;
    }
    private void OnTileSelected(Vector3 obj)
    {
        if(isSelected)
        {
			Debug.Log($"{obj} - tile");
			secondPos = obj;

			Vector3 direction = new Vector3(
				secondPos.x - transform.position.x,
				secondPos.y - transform.position.y,
				secondPos.z - transform.position.z);
			transform.up = direction;

            isSelected = false;
			renderer.color = new Color(1, 1, 1, 1);
		}
    }

    private void OnMouseDown()
    {
        isSelected = true;
		renderer.color = hightlightColor;
	}

	/*private void Update()
	{
        if (Input.GetButtonDown("Fire1"))
        {
            isSelected = false;
			renderer.color = new Color(1, 1, 1, 1);
		}
	}*/
}
