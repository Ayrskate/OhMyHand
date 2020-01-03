using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoSC : MonoBehaviour {

    [Header("Parametros")]
	public ControlJuego Juego;
	public GameObject Menos2Segundos;
    [Space(10)]

    [Header("Animaciones")]
    public bool Reacciona = true;
    public Animator Anims;
    public string TriggerName;

	//Contacto con la mano
	void OnMouseDown(){
		Cortada ();

        //poner cuchillo en la mano
        Vector3 pointPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        LanzarCuchilloSC.instance.LanzarMano(pointPos);
	}
		
	public void Cortada(){
		//Aumentar el numero de cortadas
		Juego.NumCortadas++;

		//Disminuir el tiempo del nivel
		Juego.Tiempo-=2;

		//Notificar al usuario
		if (Menos2Segundos.activeSelf) {
			Menos2Segundos.SetActive (false);
		}
		Menos2Segundos.SetActive (true);

        //Puede hacer animacion
        if (Reacciona)
        {
            Animacion();
        }
	}

    void Animacion()
    {
        Anims.SetTrigger(TriggerName);
    }
}
