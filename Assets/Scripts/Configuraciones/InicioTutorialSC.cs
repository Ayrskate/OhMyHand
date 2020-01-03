using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioTutorialSC : MonoBehaviour {

    public GameObject otroBoton;
    public string primerJuego;

    private void Awake()
    {
        //Si es la primera vez que se juego desactivar el otro boton y dejar activo este
        if (PlayerPrefs.GetInt(primerJuego, 1) == 0)
        {
            otroBoton.SetActive(false);
        }
        else
        {
            //si ya se hizo el primerjuego
            gameObject.SetActive(false);
        }
    }
}
