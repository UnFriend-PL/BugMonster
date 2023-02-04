using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    [SerializeField] private Color hightlightColor = new Color(0.5f, 0,0,1);
    [SerializeField] private SpriteRenderer renderer;

	private void OnMouseEnter()
    {
		renderer.color = hightlightColor;
        Debug.Log("enter");
    }

    private void OnMouseExit()
    {
		renderer.color = new Color(1, 1, 1, 1);
    }
}
