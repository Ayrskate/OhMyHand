using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimerJuegoSC : MonoBehaviour {

    [Header("PRIMER JUEGO int")]
    public string var_PrimerJuego = "";
    [Space(10)]

    [Header("IDIOMA string")]
    public string var_SelecciónIdioma = "";
    [Space(10)]

    [Header("MUSICA int")]
    public string var_Sonido = "";
    [Space(10)]

    [Header("NIVELES int")]
    public string var_Niveles = "";
    [Space(10)]

    public Button boton_Aceptar;

    private void Awake()
    {
        //si var_PrimerJuego es diferente de cero no iniciar configuración
        if (PlayerPrefs.GetInt(var_PrimerJuego) == 0)
        {
            PrimerInicio();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Se configura todo para que sea un inicio limpio del juego
    void PrimerInicio()
    {
        //Activar Musica
        PlayerPrefs.SetInt(var_Sonido, 1);

        //Reiniciar niveles a solo el nivel 1
        PlayerPrefs.SetInt(var_Niveles, 1);

        PlayerPrefs.Save();
    }

    //Dependiendo de la seleccion del jugador
    public void SeleccionarIdioma(string idioma)
    {
        //Poner idioma INGLES O ESPAÑOL
        PlayerPrefs.SetString(var_SelecciónIdioma, idioma);
        PlayerPrefs.Save();

        //Hacer disponible el boton aceptar
        boton_Aceptar.interactable = true;
    }

    //clic del boton de aceptar
    public void BotonAceptar()
    {
        //Acabar primerJuego
        PlayerPrefs.SetInt(var_PrimerJuego, 1);
        PlayerPrefs.Save();

        Destroy(gameObject);
    }
}
