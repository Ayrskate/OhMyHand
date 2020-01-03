using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostJuegoSC : MonoBehaviour {

    public ControlJuego Juego;
    public string nombreNiveles="";
    public int IdEsteNivel;

	public void CambiarEscena(int escena){
		SceneManager.LoadScene (escena);
	}

    public void RepetirNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnEnable()
    {
        Resultado();
    }

    void Resultado()
    {
        //obtener numero de niveles desbloqueados
        int niveles = PlayerPrefs.GetInt(nombreNiveles, 1);

        //Si gano desbloquear siguiente nivel
        if (Juego.Gano && niveles == IdEsteNivel)
        {
            PlayerPrefs.SetInt(nombreNiveles, niveles + 1);
            PlayerPrefs.Save();

            Debug.Log("Siguiente Nivel Desvloqueado " + niveles.ToString());
        }
    }
}
