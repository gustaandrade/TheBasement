#pragma strict

import UnityEngine.UI;
import UnityEngine.SceneManagement;

var currentSanity : float = 1.0;
var maxSanity : float = 100.0;
var minSanity : float = 0.0;

//var canvas: Image;

function Start() 
{
	//canvas = GameObject.Find("Image").GetComponent(Image);
}

function Update()
{
	if(currentSanity <= 100)
	{
		currentSanity -= Time.deltaTime;
		//canvas.color.a -= Time.deltaTime;
	}
	
	if(currentSanity >= 100)
	{
		currentSanity = maxSanity;
	}
	
	if(currentSanity <= 0)
	{
		currentSanity = minSanity;
	}

	/*if(canvas.color.a >= 0.7)
	{
		canvas.color.a = 0.7;
	}

	if(canvas.color.a <= 0.0)
	{
		canvas.color.a = 0.0;
	}*/
	if (currentSanity == 100)
	{
		SceneManager.LoadScene(1);
	}
}

function OnGUI()
{
	GUI.Box(Rect(5, 5, 55, 25), "Medo");
	GUI.Box(Rect(65, 5, 55, 25), currentSanity.ToString("0") + "/" + maxSanity);
}

function OnTriggerStay(Col : Collider) 
{
	if(Col.tag == "Sombra")
	{
		currentSanity += Time.deltaTime * 10;
		//canvas.color.a += 0.03;
	}
}