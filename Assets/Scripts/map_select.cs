using UnityEngine;
using System.Collections;

public class map_select : MonoBehaviour {

	public float answer;
	public string level;
	float guess=0;
	float wrongcount=0;

	public GameObject correct;
	public GameObject incorrect;
	public GameObject WinText;
	public GameObject FailText;

	Ray ray;
	RaycastHit hit;

	void Start () {
		WinText.SetActive(false);
		FailText.SetActive(false);
	
	}

	void Update () {

		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));

		if (Physics.Raycast (ray, out hit)) {

			
			Debug.Log (hit.collider.name);

			if (Input.GetMouseButtonDown (0)) 
			{

				if (hit.collider.name == ("Home_1")) {
					Application.LoadLevel("Menu");
				}

				if (hit.collider.name == ("North_1")) {
					guess=1;
					check ();
				}
				
				if (hit.collider.name == ("East_1")) {
					guess=2;
					check ();
				}				
				
				if (hit.collider.name == ("South_1")) {
					guess=3;
					check ();
				}
				
				if (hit.collider.name == ("West_1")) {
					guess=4;
					check ();
				}
				
				if (hit.collider.name == ("EastN_1")) {
					guess=5;
					check ();
				}
				
				if (hit.collider.name == ("EastS_1")) {
					guess=6;
					check ();
				}
				
				if (hit.collider.name == ("WestS_1")) {
					guess=7;
					check ();
				}
				
				if (hit.collider.name == ("WestN_1")) {
					guess=8;
					check ();
				}
			}
		}
	}

	void check()
	{
		if (answer == guess) { WinText.SetActive (true); correct.SendMessage("playSound"); StartCoroutine(waitnload()); }

		if(guess != answer) { startwrong(); incorrect.SendMessage("playSound"); wrongcount++; }

		if (wrongcount > 2) { startwait(); }
	}

	IEnumerator waitnload()
	{
		yield return new WaitForSeconds(1.5f);
		Application.LoadLevel(level);
	}

	void startwait(){ StartCoroutine(waitnload()); }

	IEnumerator wrongtext()
	{ 
		FailText.SetActive (true);
		yield return new WaitForSeconds(1f);
		FailText.SetActive (false);
	}

	void startwrong(){ StartCoroutine(wrongtext()); }
}
