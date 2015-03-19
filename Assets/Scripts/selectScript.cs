using UnityEngine;
using System.Collections;



//
//

// Attach this script to the dummy cam @ - cameraRig>tracking>center_anchor>look_cam

//
//using System.Collections;


public class selectScript : MonoBehaviour {
	//Create a ray and a ray hit
	Ray ray;
	RaycastHit hit;
	//Vector3 direction;
	//public GameObject sb;
	//public GameObject fb;
	//public GameObject mb;

	


	//public string[] ArrayLevel = {"Spatial", "Focus", "Memory"};
	//public string level;
	
	void Update () 
	{


		//Vector3 direction = transform.TransformDirection (new Vector3 (0f, 0f, 100));	

		//set up ray to dummy cam
		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));
		//ray = Camera.main.ScreenPointToRay (direction);

		//if raycast colides with something
		if (Physics.Raycast (ray, out hit)) 
		{

			//tells you what the ray is hitting
			//Debug.Log (hit.collider.name);

			//if ray collides and mouse clicked/touched
			if (Input.GetMouseButtonDown (0)) 
			{
				Debug.Log("CLICK");
				//buttons have empty game objects with colliders parented
				if (hit.collider.name == ("Right_1")) {
					GameObject.Find("CanvasMenu").SendMessage("RightSelection");
					//Debug.Log("HIT");
				
				}

				if (hit.collider.name == ("Left_1")) {
					GameObject.Find("CanvasMenu").SendMessage("LeftSelection");
					//Debug.Log("HIT");

				}
				
				if (hit.collider.name == ("Start_1")) {
				
					GameObject.Find("CanvasMenu").SendMessage("StartSelection");
				}
				
				//(ignore) used to reset renderers 
				if (hit.collider.name == ("Exit_1")) {
					//Exit
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
		//Debug.DrawRay (transform.position, new Vector3 (0, 0, 100), Color.green);

	}

	



}
