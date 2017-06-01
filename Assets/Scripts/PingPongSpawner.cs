using UnityEngine;
using System.Collections;

public class PingPongSpawner : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3 (Mathf.PingPong (transform.position.x, 5), transform.position.y, transform.position.z);
	}
}
