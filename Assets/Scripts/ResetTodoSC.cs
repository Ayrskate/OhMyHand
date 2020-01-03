using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTodoSC : MonoBehaviour {

    [Header("Parametros")]
    public string PrimerJuego;
    public string Niveles;

    public void ResetJuego()
    {
        PlayerPrefs.SetInt(PrimerJuego, 0);
        PlayerPrefs.SetInt(Niveles, 1);
        PlayerPrefs.Save();

        Application.Quit();
    }
}
