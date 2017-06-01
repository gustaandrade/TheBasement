using UnityEngine;
using System.Collections;

public class ManipularCofre : MonoBehaviour
{

	public GameObject massaneta;
	public Canvas sucesso;
	private bool flag1 = false;
	private bool flag2 = false;
	public AudioSource efeito;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log (massaneta.transform.localEulerAngles);
		Debug.Log ("Flag1 = " + flag1);
		Debug.Log ("Flag2 = " + flag2);

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			massaneta.transform.Rotate (0, 0, -5);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			massaneta.transform.Rotate (0, 0, 5);
		}
		if ((massaneta.transform.localEulerAngles.z == 300) && (flag1 == false)) {
			if (Input.GetKeyDown (KeyCode.E)) {
				//sucesso.gameObject.SetActive (true);
				flag1 = true;
				efeito.Play ();
			}
		}
		if ((massaneta.transform.localEulerAngles.z == 270) && (flag1 == true) && (flag2 == false)) {
			if (Input.GetKeyDown (KeyCode.E)) {
				//sucesso.gameObject.SetActive (true);
				flag2 = true;
				efeito.Play ();
			}
		}
		if ((massaneta.transform.localEulerAngles.z < 160) && (massaneta.transform.localEulerAngles.z > 140) && (flag1 == true) && (flag2 == true)) {
			if (Input.GetKeyDown (KeyCode.E)) {
				sucesso.gameObject.SetActive (true);
				efeito.Play ();
			}
		} 
	}
}
