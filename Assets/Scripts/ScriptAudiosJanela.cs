using UnityEngine;
using System.Collections;

public class ScriptAudiosJanela : MonoBehaviour
{

	public AudioSource grito;
	public AudioSource tiro;

	void Start ()
	{
		StartCoroutine (Sons ());
	}

	IEnumerator Sons ()
	{
		yield return new WaitForSeconds (1);
		grito.Play ();
		yield return new WaitForSeconds (1);
		tiro.Play ();
		yield return new WaitForSeconds (0.5f);
		tiro.Play ();
		yield return new WaitForSeconds (0.5f);
		tiro.Play ();

	}
}
