﻿using UnityEngine;
using System.Collections;

public class playsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void playSound(){GetComponent<AudioSource>().Play();}
}
