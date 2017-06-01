using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour
{

	public GameObject myCamera;
	private CameraManager myCameraManager;

	// Use this for initialization
	void Start ()
	{
		myCameraManager = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<CameraManager> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag ("Player")) {
			myCameraManager.DeactivateAllCameras ();
			myCamera.SetActive (true);
		}
	}
}
