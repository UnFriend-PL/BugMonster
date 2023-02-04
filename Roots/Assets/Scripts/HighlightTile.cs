using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Color hightlightColor = new Color(0.5f, 0,0,1);
    [SerializeField] private Block block;

	private void OnMouseEnter()
    {
		block.gameObject.GetComponent<SpriteRenderer>().color = hightlightColor;
    }

    private void OnMouseExit()
    {
        block.gameObject.GetComponent<SpriteRenderer>().color = new Color(128, 128, 128, 1);
    }
}
