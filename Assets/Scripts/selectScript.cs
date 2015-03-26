using UnityEngine;
using System.Collections;

public class selectScript : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	void Update () 
	{
		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));

		if (Physics.Raycast (ray, out hit)) 
		{

			if (Input.GetMouseButtonDown (0)) 
			{

				if (hit.collider.name == ("Right_1")) {
					GameObject.Find("CanvasMenu").SendMessage("RightSelection");
				}

				if (hit.collider.name == ("Left_1")) {
					GameObject.Find("CanvasMenu").SendMessage("LeftSelection");
				}
				
				if (hit.collider.name == ("Start_1")) {
					GameObject.Find("CanvasMenu").SendMessage("StartSelection");
				}

				if (hit.collider.name == ("Exit_1")) {
					Debug.Log("EXIT");
				}

				if (hit.collider.name == ("home_1")) {
					Application.LoadLevel("Menu2");
				}

				if (hit.collider.name == ("restart_1")) {
					Application.LoadLevel("A1_1");
				}
			}
		}
	}

}
