using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiguracionSC : MonoBehaviour {

    [Header("Parametros")]
    public string N_Idioma="";
    public string N_Sonido = "";

	public void CambiarIdioma(string idioma)
    {
        PlayerPrefs.SetString(N_Idioma, idioma);
        CambiarLenguaje.lenguaje = idioma;
        PlayerPrefs.Save();
    }

    public void Sonido(int estado)
    {
        PlayerPrefs.SetInt(N_Sonido, estado);
        PlayerPrefs.Save();
    }
}
