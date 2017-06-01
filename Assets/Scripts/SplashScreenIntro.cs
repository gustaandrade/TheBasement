using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreenIntro : MonoBehaviour
{

	public void LoadGame ()
	{
		SceneManager.LoadScene (1);
	}
}
