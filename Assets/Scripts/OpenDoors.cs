using UnityEngine;
using System.Collections;

public class OpenDoors : MonoBehaviour
{
	public GameObject jogador;
	public Transform destino;
	public Camera cameraatual;
	public Camera novacamera;
	public Canvas interacao;
	public Canvas itemBloco;
	public Canvas portaFechada;
	//public Animator fadeIn;
	//public Animator fadeOut;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerStay (Collider col)
	{
		if (itemBloco.isActiveAndEnabled == true) {
			if ((col.tag == "Player") && (Input.GetKeyDown (KeyCode.E))) {
				//fade.enabled = true;
				//fade.Play ("FadeInOut");
				jogador.transform.position = destino.transform.position;
				cameraatual.gameObject.SetActive (false);
				novacamera.gameObject.SetActive (true);
				//fade.enabled = false;
			}
		} else {
			portaFechada.gameObject.SetActive (true);
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player") {
			interacao.gameObject.SetActive (true);
		} 
	}

	void OnTriggerExit (Collider col)
	{
		if (col.tag == "Player") {
			interacao.gameObject.SetActive (false);
		}
		if (portaFechada.isActiveAndEnabled == true) {
			portaFechada.gameObject.SetActive (false);
		}
	}
}


