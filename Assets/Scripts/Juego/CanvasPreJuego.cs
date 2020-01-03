using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasPreJuego : MonoBehaviour {

	[Header("Parametros")]
	public GameObject Contador;
	public GameObject PlayBtn;
	public int FlagTutorial=0;

	void Start(){
		if (FlagTutorial != 0) {
			Empezar ();
		}
	}

	//metodo para el boton de play
	public void Empezar(){
		PlayBtn.SetActive (false);
		Contador.SetActive (true);
	}

	public void Menu(){
		SceneManager.LoadScene (1);
	}


}
