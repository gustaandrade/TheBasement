using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{

	public GameObject[] cameras;
	public GameObject startCamera;

	// Use this for initialization
	void Start ()
	{
		cameras = GameObject.FindGameObjectsWithTag ("MainCamera");

		for (int i = 0; i < cameras.Length; i++) {
			cameras [i].SetActive (false); 		// turns off all cameras in the scene
		}
			
		startCamera.SetActive (true);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void DeactivateAllCameras ()
	{
		for (int i = 0; i < cameras.Length; i++) {
			cameras [i].SetActive (false);
		}
	}
}
