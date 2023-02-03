using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Color baseColor, offColor;
    [SerializeField] private SpriteRenderer renderer;

    public void Init(bool isOffset)
    {
        if (isOffset) renderer.color = offColor;
        else renderer.color = baseColor;
    }
}
