using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaMenuSC : MonoBehaviour {

    [Header("Parametros")]
    public string Sonido = "";
    AudioSource AS;

    private void Awake()
    {
        AS = GetComponent<AudioSource>();
        RevisarSonido();
    }

    private void FixedUpdate()
    {
        RevisarSonido();
    }

    void RevisarSonido()
    {
        //si en pp la variable sonido es igual 1 y ademas no se esta reproduciendo musica reproduce la musica
        if (PlayerPrefs.GetInt(Sonido, 1) == 1 && !AS.isPlaying)
        {
            AS.Play();
        }
        else if (PlayerPrefs.GetInt(Sonido, 1) == 0)
        {
            AS.Stop();
        }
    }
}
