using UnityEngine;
using System.Collections;

public class SpawnaLixo : MonoBehaviour
{
	public GameObject lixo1;
	public GameObject lixo2;

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player") {
			Vector3 position1 = new Vector3 (Random.Range (-5.0f, 5.0f), 0, Random.Range (-5.0f, 5.0f));
			Instantiate (lixo1, transform.position + position1, Quaternion.identity);
		}
	}
}
