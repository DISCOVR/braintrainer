using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour {

	public Image SelectionText;
	public List<Sprite> ItemList = new List<Sprite>();
	private int itemSpot = 0;
	public GameObject toggle;
	public GameObject start;
	public GameObject incorrect;

	void Update()
	{

	}


	public void RightSelection()
	{

		toggle.SendMessage("playSound");
		if(itemSpot < 1){itemSpot = 3;}
		itemSpot-=1;
		SelectionText.sprite = ItemList[itemSpot];

	}

	public void LeftSelection()
	{

		toggle.SendMessage("playSound");
		if(itemSpot > 1){itemSpot = -1;}
		itemSpot+=1;
		SelectionText.sprite = ItemList [itemSpot];

	}

	public void StartSelection()
	{
		if(itemSpot == 0)
		{
			Application.LoadLevel ("A1");
			start.SendMessage("playSound");
		}
		else if(itemSpot == 1)
		{
			Application.LoadLevel ("");
			incorrect.SendMessage("playSound");
		}
		else if(itemSpot == 2)
		{
			Application.LoadLevel ("");
			incorrect.SendMessage("playSound");
		}
	}
}
