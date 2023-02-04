using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SelectAnt : MonoBehaviour
{
    //public int HP;
    bool isSelected = false;

    Vector3 firstPos, secondPos;
    public float speed = 0.5f;
	[SerializeField] private SpriteRenderer renderer;
	[SerializeField] private Color hightlightColor = new Color(0.5f, 0, 0, 1);
    [SerializeField] NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }


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

    private void Update()
    {
        SetAgentPosition();
    }

    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(secondPos.x, secondPos.y, transform.position.z));
    }
}
