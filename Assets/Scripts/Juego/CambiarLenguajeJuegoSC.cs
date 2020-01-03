using UnityEngine;
using UnityEngine.UI;

public class CambiarLenguajeJuegoSC : MonoBehaviour {

    //Este script es para cambiar el lenguaje de la interfaz dentro del juego

    [Header("Parametros")]
    public string var_Idioma = "";
    public string Español = "";
    public string Ingles = "";

    Text texto;

	// Use this for initialization
	void Awake () {
        texto = GetComponent<Text>();

        if (PlayerPrefs.GetString(var_Idioma, "Español") == "Ingles")
        {
            texto.text = Ingles;
        }
        else
        {
            texto.text = Español;
        }
	}
}
