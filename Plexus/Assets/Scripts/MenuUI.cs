using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour {


//	public string spatialLevel;
//	public string focusLevel;
//	public string memoryLevel;
	//public Button spatialButtton;
	//public Button focusButtton;
	//public Button memoryButtton;
	public GameObject sb;
	public GameObject fb;
	public GameObject mb;
	public bool Sbool;
	//public bool Fbool;
	//public bool Mbool;

	public int size = 0;


	void Start()
	{
		//Debug.Log (size);
//		sb.SetActive(true);
//		fb.SetActive(false);
//		mb.SetActive(false);

		Sbool = false;
		//Fbool = false;
		//Mbool = false;
	}

	void Update()
	{

		if(Input.GetButtonDown("Fire1"))
		   {

			ButtonPressed ();

			if(size == 1)
			{
				Sbool = true;
				sb.SetActive(true);
				fb.SetActive(false);
				mb.SetActive(false);
				//Debug.Log("sb");
			}
			else if (size == 2)
			{
				Sbool = false;
				fb.SetActive(true);
				sb.SetActive(false);
				mb.SetActive(false);
				//Debug.Log("fb");
			}
			else if (size == 3)
			{
				Sbool = false;
				mb.SetActive(true);
				sb.SetActive(false);
				fb.SetActive(false);
				//Debug.Log("mb");
			}
		}
	}

	public void ButtonPressed()
	{
		if(gameObject.name == "SpatialInte")
		{
			size = 1;
			Debug.Log("Spatial Pressed");
			//spatialButtton.interactable = true;
			sb.SetActive(true);
			//focusButtton.interactable = false;
			fb.SetActive(false);
			//memoryButtton.interactable = false;
			mb.SetActive(false);
			Application.LoadLevel("Spatial");


		}
		else if(gameObject.name == "Focus")
		{
			size = 2;
			Debug.Log("Focus Pressed");
			//spatialButtton.interactable = true;
			sb.SetActive(false);
			//focusButtton.interactable = false;
			fb.SetActive(true);
			//memoryButtton.interactable = false;
			mb.SetActive(false);
			//Application.LoadLevel("Spatial");


		}
		else if(gameObject.name == "Memory")
		{
			size = 3;
			Debug.Log("Memory Pressed");
			
			//spatialButtton.interactable = true;
			sb.SetActive(false);
			//focusButtton.interactable = false;
			fb.SetActive(false);
			//memoryButtton.interactable = false;
			mb.SetActive(true);
			//Application.LoadLevel(memoryLevel);



		}

		else if(gameObject.name == "Left")
		{
			//Debug.Log("Left");
			size++;
			Debug.Log(size);
			if(size == 4)
			{
				size = 1;
			}

		}
		else if(gameObject.name == "Right")
		{
			//Debug.Log("Right");
			size--;
			Debug.Log(size);
			if(size <= 0)
			{
				size = 3;
			}
		}
		else if(gameObject.name == "Start")
		{
			if(Sbool == true)
			Application.LoadLevel("Statial");
		}
		else if(gameObject.name == "Quit")
		{

			
		}
	}



		

















}
