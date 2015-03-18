using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class A1 : MonoBehaviour {

//	public Button Nbutton;
//	public Button Ebutton;
//	public Button Sbutton;
//	public Button Wbutton;


//	public int north = 1;
//	public int east = 2;
//	public int south = 3;
//	public int west = 4;

	//public string WinLevel;
	
	public bool correctAnswer = false;

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (correctAnswer == true)
		{
			Debug.Log ("CORRECT");
			Application.LoadLevel("A2");
		}


		//set up ray to dummy cam
		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));
		//ray = Camera.main.ScreenPointToRay (direction);
		
		//if raycast colides with something
		if (Physics.Raycast (ray, out hit)) {

			//ButtonPressed();

			Debug.Log (hit.collider.name);
			
			//if ray collides and mouse clicked/touched
			if (Input.GetMouseButtonDown (0)) 
			{
				Debug.Log("CLICK");
				//buttons have empty game objects with colliders parented
				if (hit.collider.name == ("North_1")) {
					Application.LoadLevel("A2");
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("North");
					Debug.Log("North");
				}
				
				if (hit.collider.name == ("East_1")) {
					Application.LoadLevel("A2");
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("East");
					Debug.Log("East");
				}				

				if (hit.collider.name == ("South_1")) {
					Application.LoadLevel("A2");
					GameObject.Find("CanvasA1").SendMessage("South");
					correctAnswer = true;
					Debug.Log("South");
				}

				if (hit.collider.name == ("West_1")) {
					Application.LoadLevel("A2");
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("South");
					Debug.Log("West");
				}

				if (hit.collider.name == ("NorthEast_1")) {
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("Right");
					//Debug.Log("North");
				}

				if (hit.collider.name == ("EastSouth_1")) {
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("Right");
					//Debug.Log("North");
				}

				if (hit.collider.name == ("SouthWest_1")) {
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("Right");
					//Debug.Log("North");
				}

				if (hit.collider.name == ("NorthWest_1")) {
					//GameObject.Find("CanvasA1").SendMessage("RightSelection");
					GameObject.Find("CanvasA1").SendMessage("Right");
					//Debug.Log("North");
				}
			}
		}


	}

//	public void ButtonPressed()
//	{
//		if (gameObject.name == "North")
//		{
//			Debug.Log("NORTH ");
//
//		}
//		else if (gameObject.name == "East")
//		{
//			Debug.Log("EAST ");
//
//
//		}
//		else if (gameObject.name == "South")
//		{
//			Debug.Log("SOUTH ");
//			correctAnswer = true;
//			
//		}
//		else if (gameObject.name == "West")
//		{
//			Debug.Log("WEST ");
//
//			
//		}
//	}
}
