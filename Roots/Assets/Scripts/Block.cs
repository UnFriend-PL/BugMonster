using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;

public class Block : MonoBehaviour
{
	private bool isWalkable = true;
	public bool isDestructable = true;
	public bool miningWood = false;
	private bool isClicked = false;
	[SerializeField] public int probabilityOfFood = 3;
	[SerializeField] public int time = 3;
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
	[SerializeField] SpriteRenderer renderer;
	[SerializeField] Color HighlightColor = Color.magenta;

	private void Start()
	{
		ChangeType();
	}
	private void OnValidate()
	{
		Start();
		ChangeType();
	}

	private async void OnMouseOver()
	{
		renderer.color = HighlightColor;
		if (Input.GetMouseButtonDown(1))
		{
			isClicked = true;
			await Task.Delay(time * 1000);
			isClicked = false;
		}
	}

	private void OnMouseExit()
	{
		renderer.color = Color.white;
	}


	public void ChangeType()
	{
		switch (type)
		{
			case blockType.Background:
				gameObject.tag = "Block";
				gameObject.layer = 6;
				GetComponent<SpriteRenderer>().sprite = BackgroundSprite;
				isWalkable = true;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Dirt:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = DirtSprite;
				isWalkable = false;
				isDestructable = true;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Stone:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = StoneSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndDown:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootEndDownSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndUp:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootEndUpSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndLeft:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootEndLeftSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootEndRight:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootEndRightSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootHorizontal:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootHorizontalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.RootVertical:
				gameObject.tag = "Block";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = RootVerticalSprite;
				isWalkable = false;
				isDestructable = miningWood;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Leaf:
				gameObject.tag = "Food";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = LeafSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Berry:
				gameObject.tag = "Food";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = BerrySprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
			case blockType.Larvae:
				gameObject.tag = "Food";
				gameObject.layer = 0;
				GetComponent<SpriteRenderer>().sprite = LarvaeSprite;
				isWalkable = false;
				isDestructable = false;
				GetComponent<NavMeshPlus.Components.NavMeshModifier>().ignoreFromBuild = !isWalkable;
				break;
		}
		if (isFoggy) GetComponent<SpriteRenderer>().sprite = FogSprite;
	}

	public bool Mine()
	{
		bool isDirt = false;
		if (isClicked && isDestructable)
		{
			System.Random rand = new System.Random();
			if (rand.Next(1, 101) <= probabilityOfFood)
			{
				switch (rand.Next(0, 3))
				{
					case 0:
						isClicked = false;
						type = blockType.Leaf;
						break;
					case 1:
						isClicked = false;
						type = blockType.Berry;
						break;
					case 2:
						isClicked = false;
						type = blockType.Larvae;
						break;
				}
			}
			else
			{
				isDirt = true;
				type = blockType.Background;
			}
			ChangeType();
			removeFogAround();
		}
		isClicked = false;
		return isDirt;
	}

	public int Eat()
	{
		if (isClicked)
		{
			if (type == blockType.Leaf)
			{
				type = blockType.Background;
				ChangeType();
				return 1;
			}
			else if (type == blockType.Berry)
			{
				type = blockType.Background;
				ChangeType();
				return 3;
			}
			else if (type == blockType.Larvae)
			{
				type = blockType.Background;
				ChangeType();
				return 5;
			}
		}
		return 0;
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

	public int Collumn()
	{
		string x = transform.parent.name;
		x = Regex.Match(x, @"\d+").Value;
		return int.Parse(x);
	}
	public int Row()
	{
		string x = transform.name;
		x = Regex.Match(x, @"\d+").Value;
		return int.Parse(x);
	}
	public string makeCollumn(int x)
	{
		return "Blocks (" + x + ")";
	}
	public string makeRow(int x)
	{
		return "Block (" + x + ")";
	}

	public void removeFogAround()
	{
		int x = Collumn(), y = Row();
		for (int i = x - 1; i != x + 2; i++)
		{
			for (int j = y - 1; j != y + 2; j++)
			{
				GameObject.Find(makeCollumn(i) + "/" + makeRow(j)).GetComponent<Block>().unFog();
			}
		}
	}

	public void unFog()
	{
		isFoggy = false;
		ChangeType();
	}
}
