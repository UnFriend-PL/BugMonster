using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isWalkable = true;
    [SerializeField] blockType type;
    [SerializeField] Sprite DirtSprite;
    [SerializeField] Sprite DarkDirtSprite;

    private void Start()
    {
        ChangeType();
    }
    private void OnValidate()
    {
        Start();
        ChangeType();
    }

    private void ChangeType()
    {
        switch (type)
        {
            case blockType.Background:
                GetComponent<SpriteRenderer>().sprite = DirtSprite;
                isWalkable = true;
                GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
                break;
            case blockType.Dirt:
                GetComponent<SpriteRenderer>().sprite = DarkDirtSprite;
                isWalkable = false;
                GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
                break;

        }
    }

    void Update()
    {

    }

    public enum blockType
    {
        Background,
        Dirt,
        Root
    }
}
