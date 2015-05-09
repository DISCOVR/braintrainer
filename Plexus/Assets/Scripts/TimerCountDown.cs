using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour {

	public Text counter;
	public Text Fail;
	public Text Win;

	public float timer;
	public float newTimer;

	public GameObject WinText;
	public GameObject FailText;
	public GameObject CounterText;

	// Use this for initialization
	void Start () {
		WinText.SetActive(false);
		FailText.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
		timer -= Time.deltaTime;
		counter.text = ("" + timer);
		if(timer <= 0)
		{
			FailText.SetActive(true);
			CounterText.SetActive(false);

			timer = newTimer;
		}

	}
}
