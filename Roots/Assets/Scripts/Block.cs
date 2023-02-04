using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
	private bool isWalkable = true;
	public bool isDestructable = true;
	public bool miningWood = false;
	[SerializeField] public int probabilityOfFood = 3;
	[SerializeField] public bool isFoggy = true;
	[SerializeField] public blockType type;
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
	[SerializeField] Sprite LeafSprite;
	[SerializeField] Sprite BerrySprite;
	[SerializeField] Sprite LarvaeSprite;

	private void Start()
	{
		ChangeType();
	}
	private void OnValidate()
	{
		Start();
		ChangeType();
	}

	public void ChangeType()
	{
		switch (type)
		{
			case blockType.Background:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = BackgroundSprite;
				isWalkable = true;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Dirt:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = DirtSprite;
				isWalkable = false;
				isDestructable = true;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Stone:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = StoneSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndDown:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootEndDownSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndUp:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootEndUpSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndLeft:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootEndLeftSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndRight:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootEndRightSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootHorizontal:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootHorizontalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootVertical:
				gameObject.tag = "Block";
				GetComponent<SpriteRenderer>().sprite = RootVerticalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Leaf:
				gameObject.tag = "Food";
				GetComponent<SpriteRenderer>().sprite = LeafSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Berry:
				gameObject.tag = "Food";
				GetComponent<SpriteRenderer>().sprite = BerrySprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Larvae:
				gameObject.tag = "Food";
				GetComponent<SpriteRenderer>().sprite = LarvaeSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
		}
		if (isFoggy) GetComponent<SpriteRenderer>().sprite = FogSprite;
	}

	public void Mine()
	{
		if (isDestructable)
		{
			System.Random rand = new System.Random();
			if (rand.Next(1, 101) <= probabilityOfFood)
			{
				switch (rand.Next(0, 3))
				{
					case 0:
						type = blockType.Leaf;
						break;
					case 1:
						type = blockType.Berry;
						break;
					case 2:
						type = blockType.Larvae;
						break;
				}
			}
			else
			{
				type = blockType.Background;
			}
			ChangeType();
		}
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
		RootEndDown,
		Leaf,
		Berry,
		Larvae
	}
}
