using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Color hightlightColor = new Color(0.5f, 0,0,1);
    [SerializeField] private SpriteRenderer renderer;

    private void OnMouseEnter()
    {
        renderer.color = hightlightColor;
    }

    private void OnMouseExit()
    {
        renderer.color = new Color(1, 1, 1, 1);
    }
}
