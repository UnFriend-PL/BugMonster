using System.Collections;
using System.Collections.Generic;
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

	private void Start()
	{
		ChangeType();
	}
	private void OnValidate()
	{
		Start();
		ChangeType();
	}

	/*private void OnMouseDown()
	{
		isClicked = true;
		firstclick = true;
		Debug.Log("on");
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			if (firstclick) firstclick = false;
			else if (isClicked)	isClicked = false;
			else
			{
				isClicked = true;
				firstclick = true;
			}
		}
	}*/

	private async void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{
			Debug.Log("AAA");
			isClicked = true;
			await Task.Delay(time * 1000);
			isClicked= false;
			Debug.Log("AAABBB");
		}
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

	public void Mine()
	{
		if(isClicked)
		{
			Debug.Log("mine!");
			if (isDestructable)
			{
				Debug.Log("mine That!");
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
	}

	public int Eat()
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
		else return 0;
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
