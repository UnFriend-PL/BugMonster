using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Material originalMaterial;

    public Material highlightMaterial;

    private void Start()
    {
        originalMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = highlightMaterial;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = originalMaterial;
    }
}
