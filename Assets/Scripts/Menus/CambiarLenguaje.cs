using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarLenguaje : MonoBehaviour {

    [Header("Contenido")]
    public string Español = "";
    public string Ingles = "";
    [Space(10)]

    [Header("Parametros")]
    public static string lenguaje = "";

    Text texto;

    // Use this for initialization
    void Start() {
        texto = GetComponent<Text>();
        lenguaje = PlayerPrefs.GetString("var_Idioma", "Español");
    }

    // Update is called once per frame
    void FixedUpdate() {
        Lenguaje();
    }
    
    void Lenguaje()
    {
        if (lenguaje == "Ingles")
        {
            texto.text = Ingles;
        }
        else
        {
            texto.text = Español;
        }
    }
}
