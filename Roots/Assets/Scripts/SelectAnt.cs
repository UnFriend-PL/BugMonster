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
        agent.updateUpAxis = false;
    }

    void Start()
    {
        SelecTile.selectedTile += OnTileSelected;
    }

    Vector2 lastPos;
    private void Update()
    {
        SetAgentPosition();
        var deltaPos = (Vector2)transform.position - lastPos;
        if (deltaPos.magnitude > 0.001f)
        {
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(deltaPos.y, deltaPos.x) * Mathf.Rad2Deg - 90);
        }
        lastPos = transform.position;
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
            isSelected = false;
			renderer.color = new Color(1, 1, 1, 1);
		}
    }

    private void OnMouseDown()
    {
        isSelected = true;
		renderer.color = hightlightColor;
	}

    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(secondPos.x, secondPos.y, transform.position.z));
        //agent.transform.rotation = Quaternion.LookRotation(secondPos - transform.position, Vector3.forward);
    }
}
