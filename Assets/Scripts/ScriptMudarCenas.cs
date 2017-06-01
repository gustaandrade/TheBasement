using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScriptMudarCenas : MonoBehaviour
{
	public void LoadNovoJogo ()
	{
		SceneManager.LoadScene (2);
	}

	public void LoadCena1 ()
	{
		SceneManager.LoadScene (2);
	}

	public void LoadCena2 ()
	{
		SceneManager.LoadScene (3);
	}

	public void LoadCena3 ()
	{
		SceneManager.LoadScene (4);
	}

	public void LoadCena4 ()
	{
		SceneManager.LoadScene (5);
	}

	public void LoadCreditos ()
	{
		SceneManager.LoadScene (6);
	}

	public void SairJogo ()
	{
		Application.Quit ();
	}

}
