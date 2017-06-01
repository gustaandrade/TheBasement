using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractScript : MonoBehaviour
{
	public Canvas geladeira;
	public Canvas cofre;
	public Canvas interacao;
	public Canvas itemBloco;
	//public Canvas canvasPreto;
	public Light sol;

	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1;
		sol.intensity = 0.8f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log (Time.timeScale);

		//canvasPreto.color.a -= 0.01f;
		sol.intensity += 0.01f;

		if (Time.timeScale <= 0.3f) {
			Time.timeScale = 0.3f;
			SceneManager.LoadScene (3);
		}
		if (Time.timeScale >= 1) {
			Time.timeScale = 1;
		}
		if (sol.intensity >= 0.8f) {
			sol.intensity = 0.8f;
		}
		if (sol.intensity <= 0.2f) {
			sol.intensity = 0.2f;
		}

		Time.timeScale += 0.01f;
	}

	void OnTriggerStay (Collider col)
	{
		if ((col.tag == "Geladeira") && (Input.GetKeyDown (KeyCode.E))) {
			geladeira.gameObject.SetActive (true);
			itemBloco.gameObject.SetActive (true);
		}

		if ((col.tag == "Cofre") && (Input.GetKeyDown (KeyCode.E))) {
			cofre.gameObject.SetActive (true);
		}

		if (col.tag == "Sombra") {
			Time.timeScale -= 0.02f;
			//canvasPreto.color.a += 0.02f;
			sol.intensity -= 0.02f;
		}

		if ((col.tag == "Janelinha") && (Input.GetKeyDown (KeyCode.E))) {
			SceneManager.LoadScene (8);
		}

		/*if ((col.tag == "Boneco") && (Input.GetKeyDown (KeyCode.E))) {
			canvasPreto.gameObject.SetActive (true);
		}*/
	}

	void OnTriggerEnter (Collider col)
	{
		if ((col.tag != "TriggerCamera") && (col.tag != "Sombra") && (col.tag != "Lixo")) {
			interacao.gameObject.SetActive (true);
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.tag == "Geladeira") {
			geladeira.gameObject.SetActive (false);
			interacao.gameObject.SetActive (false);
		}

		if (col.tag == "Cofre") {
			cofre.gameObject.SetActive (false);
			interacao.gameObject.SetActive (false);
			SceneManager.LoadScene (7);
		}
	}
}