using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControleCanvas : MonoBehaviour
{

	public GameObject menuInicial;
	public GameObject menuCenas;
	public GameObject menuOpcoes;
	public GameObject menuControles;

	public void LigarCenas ()
	{
		menuInicial.SetActive (false);
		menuCenas.SetActive (true);
	}

	public void DesligarCenas ()
	{
		menuInicial.SetActive (true);
		menuCenas.SetActive (false);
	}

	public void LigarOpcoes ()
	{
		menuInicial.SetActive (false);
		menuOpcoes.SetActive (true);
	}

	public void DesligarOpcoes ()
	{
		menuInicial.SetActive (true);
		menuOpcoes.SetActive (false);
	}

	public void LigarControles ()
	{
		menuOpcoes.SetActive (false);
		menuControles.SetActive (true);
	}

	public void DesligarControles ()
	{
		menuOpcoes.SetActive (true);
		menuControles.SetActive (false);
	}

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
