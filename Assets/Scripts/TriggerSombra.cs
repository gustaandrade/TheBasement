using UnityEngine;
using System.Collections;

public class TriggerSombra : MonoBehaviour
{
	public GameObject sombra;
	public GameObject waypoints;
	public GameObject musica1;
	public GameObject musica2;

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag ("Player")) {
			Instantiate (sombra);
			Instantiate (waypoints);

			musica1.SetActive (false);
			musica2.SetActive (true);
		}
	}
}
