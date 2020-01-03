using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorSc : MonoBehaviour {

	int Tiempo=3;
	public GameObject CanvasJuego;
	public GameObject Zonas;
	public MeshCollider EvitarContacto; 
	public ControlJuego juego;
	
	//Metodo para la cuenta regresiva
	public void Rtiempo(){
		Tiempo--;
		GetComponent<Text> ().text = Tiempo.ToString();
		if (Tiempo == 0) {
			//Activar las zonas y el canvas de juego
			CanvasJuego.SetActive (true);
			Zonas.SetActive (true);

			//Activar collider de mano
			EvitarContacto.enabled=true;

			//Activar la zona
			juego.CambiarZona();

			//desactivar este canvas
			transform.parent.gameObject.SetActive(false);
		}

	}
}
