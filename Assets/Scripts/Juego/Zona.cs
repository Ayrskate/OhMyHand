using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour {

	[Header("Parametros")]
	public ControlJuego Juego;
	public Material Mat;
	public bool Elegido = false;
    public int IdZona;

	public void Awake(){
		Mat.color = new Color(Mat.color.r,Mat.color.g,Mat.color.b,0f);//invisible
	}

	public void Iluminar(){
		Mat.color = new Color(Mat.color.r,Mat.color.g,Mat.color.b,0.7f);//activo
	}

	public void DesIluminar(){
		Mat.color = new Color(Mat.color.r,Mat.color.g,Mat.color.b,0f);//despues de seleccionar
	}

	void OnMouseDown(){
		//El hit correcto
		if (Elegido) {
			Juego.CambiarZona ();
			Elegido = false;
			Juego.NumHits++;            
		} else {
			//Poner consecuencia de mal hit
			Debug.Log ("Error");
		}
        LanzarCuchilloSC.instance.LanzarEnZona(IdZona);
    }
    

}
