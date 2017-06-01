using UnityEngine;
using System.Collections;

public class TweenCameraIntro : MonoBehaviour
{

	void Start ()
	{
		Vector3[] path = iTweenPath.GetPath ("CaminhoCamera");
		transform.position = path [0];
		iTween.MoveTo (gameObject, iTween.Hash ("path", path, "time", 90, "looktime", 0.01f, "orienttopath", true, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
	}
}
