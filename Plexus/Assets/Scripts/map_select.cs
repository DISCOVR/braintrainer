using UnityEngine;
using System.Collections;

public class map_select : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public float speed;

	public GameObject player;
	void Start () {
	
	}

	void Update () {

		ray = Camera.current.ScreenPointToRay (new Vector3 ((Screen.width / 2f), (Screen.height / 2f), 0));

		if (Physics.Raycast (ray, out hit)) {

			if (Input.GetMouseButtonDown (0)) 
			{
				//Debug.DrawLine(ray.origin,hit,Color.red);
				//Debug.DrawRay(ray.origin,hit,Color.red);
				//Debug.Log("HIT: " + hit.collider.name);
				player = GameObject.Find("Player");

				if (hit.collider.tag == ("left")) {
					Debug.Log (hit.collider.name);
					player.transform.Rotate (Vector3.down * speed);
				}
				if (hit.collider.tag == ("right")) {
					Debug.Log (hit.collider.name);
					player.transform.Rotate (Vector3.up * speed);
				}
				

			}
		}
	
	}
}
