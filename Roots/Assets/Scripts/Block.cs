using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isWalkable = true;
	private bool isDestructable = true;
    public bool miningWood = false;
	[SerializeField] public bool isFoggy = true;
	[SerializeField] blockType type;
    [SerializeField] Sprite BackgroundSprite;
    [SerializeField] Sprite DirtSprite;
	[SerializeField] Sprite StoneSprite;
	[SerializeField] Sprite RootVerticalSprite;
	[SerializeField] Sprite RootHorizontalSprite;
	[SerializeField] Sprite RootEndLeftSprite;
	[SerializeField] Sprite RootEndRightSprite;
	[SerializeField] Sprite RootEndUpSprite;
	[SerializeField] Sprite RootEndDownSprite;
	[SerializeField] Sprite FogSprite;

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
                GetComponent<SpriteRenderer>().sprite = BackgroundSprite;
                isWalkable = true;
                isDestructable = false;
                GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
                break;
            case blockType.Dirt:
                GetComponent<SpriteRenderer>().sprite = DirtSprite;
                isWalkable = false;
				isDestructable = true;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
                break;
			case blockType.Stone:
				GetComponent<SpriteRenderer>().sprite = StoneSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndDown:
				GetComponent<SpriteRenderer>().sprite = RootEndDownSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndUp:
				GetComponent<SpriteRenderer>().sprite = RootEndUpSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndLeft:
				GetComponent<SpriteRenderer>().sprite = RootEndLeftSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndRight:
				GetComponent<SpriteRenderer>().sprite = RootEndRightSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootHorizontal:
				GetComponent<SpriteRenderer>().sprite = RootHorizontalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootVertical:
				GetComponent<SpriteRenderer>().sprite = RootVerticalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
		}
		if(isFoggy) GetComponent<SpriteRenderer>().sprite = FogSprite;
	}

    public enum blockType
    {
        Background,
        Dirt,
        Stone,
		RootHorizontal,
		RootVertical,
		RootEndLeft,
		RootEndRight,
		RootEndUp,
		RootEndDown
    }
}
