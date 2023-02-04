using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    [SerializeField] private Color hightlightColor = new Color(0.5f, 0,0,1);
    [SerializeField] private SpriteRenderer renderer;

	private void OnMouseEnter()
    {
		renderer.gameObject.GetComponent<SpriteRenderer>().color = hightlightColor;
        Debug.Log("enter");
    }

    private void OnMouseExit()
    {
        renderer.gameObject.GetComponent<SpriteRenderer>().color = new Color(128, 128, 128, 1);
    }
}
