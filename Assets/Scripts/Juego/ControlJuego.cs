using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJuego : MonoBehaviour {

	[Header("Zonas")]
	public Zona[] Zonas;

	[Space(10)]
	[Header("Juego")]
	public int ZSeleccion;
	public float Tiempo;
	public int MetaHits;

	[Space(10)]
	[Header("CanvasJuego")]
	public Text Cortadas;
	public Text Hits;
	public int NumCortadas=0;
	public int NumHits=0;
	public Text TiempoText;
	public GameObject CanvasJuego;
	[Space(10)]

	[Header("CanvasPostJuego")]
	public GameObject CanvasPost;
	public Text Resultado;
    public GameObject Repetir;
    public GameObject SiguienteNivel;
	[Space(10)]

	[Header("Resultado")]
	public bool Gano=false;
    public string idioma="";


	//Empezando el juego
	void Start () {
		ZSeleccion = Random.Range (0, 6);
		Invoke ("CambiarZona", 0.1f);
	}

	//Cambiar el numero de la zona seleccionada desde otros scripts
	public void CambiarZona(){
		//Desiluminar la zona que ya se selecciono y Deselegir
		int Num = ZSeleccion;
		Zonas [ZSeleccion].DesIluminar ();

		//Sin que se repita numero
		ZSeleccion = Random.Range (0, 6);
		if (ZSeleccion == Num) {
			CambiarZona ();
		} else {
			//Iluminar nueva Zona
			Zonas [ZSeleccion].Iluminar ();
			Zonas [ZSeleccion].Elegido = true;
		}
	}

	void Update(){
        Juego();
	}

    void Juego()
    {
        if (CanvasJuego.activeSelf)
        {
            Cortadas.text = NumCortadas.ToString();
            Hits.text = (MetaHits - NumHits).ToString();
            TiempoText.text = Tiempo.ToString("0");


            //Comprobacion de tiempo
            Tiempo -= Time.deltaTime;
            if (Tiempo <= 0 || NumHits >= MetaHits)
            { //terminar el juego si se acaba el tiempo o si ya se alcanzo la meta 
                FinJuego();
            }
        }
    }

	void FinJuego(){

		//Resultado
		if (NumHits >= MetaHits) {
			//Resultado.text = "Win!";
            Repetir.SetActive(false); //desactivar boton de repetir si gana
            SiguienteNivel.SetActive(true);
            Gano = true;
		} else {
			//Resultado.text = "Lose!";
            Repetir.SetActive(true); 
            SiguienteNivel.SetActive(false); //desactivar boton de siguiente nivel si pierde
            Gano = false;
		}

        //Desactivar Cavnas Juego y mostrar el postJuego
        CanvasJuego.SetActive(false);
        CanvasPost.SetActive(true);

        //Desiluminar zonas
        DescativarZonas();

        //Plasmar Resultado acorde al idioma y el resultado de la partida
        PonerResultado();
    }

    void PonerResultado()
    {
        //Ganar
        if (Gano)
        {
            if (PlayerPrefs.GetString(idioma, "Español") == "Ingles")
            {
                Resultado.text = "Win!";
            }
            else
            {
                Resultado.text = "¡Ganaste!";
            }
        }
        else //si perdio
        {
            if (PlayerPrefs.GetString(idioma, "Español") == "Español")
            {
                Resultado.text = "Lose";
            }
            else
            {
                Resultado.text = "Perdiste";
            }

        }
    }

	void DescativarZonas(){
		foreach (Zona a in Zonas) {
			a.gameObject.SetActive (false);
		}
	}

}
