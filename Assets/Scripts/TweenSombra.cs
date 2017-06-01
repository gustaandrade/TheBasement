using UnityEngine;
using System.Collections;

public class TweenSombra : MonoBehaviour
{

	//public Transform target;
	//public GameObject jogador;

	void Start ()
	{
		Vector3[] path = iTweenPath.GetPath ("CaminhoSombra");
		transform.position = path [0];

		iTween.MoveTo (gameObject, iTween.Hash ("path", path, "time", 50, "orienttopath", true, "looktime", 0.01f, "easetype", iTween.EaseType.linear));
	}
}

