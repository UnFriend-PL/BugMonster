using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    [SerializeField] private Color hightlightColor = new Color(0.5f, 0, 0, 1);
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private Color orginalColor = new Color(1, 1, 1, 1);

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform == transform)
            {
                renderer.color = hightlightColor;
                return;
            }
        }
        renderer.color = orginalColor;
    }

    //private void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if(collider.gameObject.tag == "Mouse")
    //    {
    //        renderer.color = hightlightColor;
    //        Debug.Log("TILE");
    //    }
    //    Debug.Log("enter");
    //}

    //private void OnTriggerExit2D(Collider2D collider)
    //{
    //    if(collider.gameObject.tag == "Mouse")
    //    {
    //        renderer.color = orginalColor;
    //    }
    //}
}
