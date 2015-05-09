using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour {

	public Image SelectionText;
	public List<Sprite> ItemList = new List<Sprite>();
	private int itemSpot = 0;
	//private float itemSpot1 = 0;




	void Update()
	{
		Debug.Log (itemSpot);


	}


	public void RightSelection()
	{

		if(itemSpot < 1)
		{
			itemSpot = 3;
		}
		//if(itemSpot < ItemList.Count-1)
		//{
		//Debug.Log (itemSpot);
		itemSpot-=1;
			SelectionText.sprite = ItemList[itemSpot];

//			if(itemSpot <= -1)
//			{
//				itemSpot = 3;
//			}

			//SelectionText.text = ItemList [itemSpot];
		//}
	}

	public void LeftSelection()
	{

		if(itemSpot > 1)
		{
			itemSpot = -1;
		}
	//if(itemSpot > 0)
		//{
		//Debug.Log (itemSpot);

		itemSpot+=1;
			SelectionText.sprite = ItemList [itemSpot];

//			if(itemSpot >= 4)
//			{
//				itemSpot = 0;
//			}
		//}
	}

	public void StartSelection()
	{
		if(itemSpot == 0)
		{
			Application.LoadLevel ("A1");
		}
		else if(itemSpot == 1)
		{
			Application.LoadLevel ("");
		}
		else if(itemSpot == 2)
		{
			Application.LoadLevel ("");
		}
	}
}
