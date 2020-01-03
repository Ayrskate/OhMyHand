using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenusSC : MonoBehaviour {

	public void CambiarEscena(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ActivarCanvas(GameObject objeto)
    {
        objeto.SetActive(true);
    }

    public void DesactivarCanvas(GameObject objeto)
    {
        objeto.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
