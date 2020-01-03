using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarCuchilloSC : MonoBehaviour {

    [Header("PosicionesZonas")]
    public Transform[] Posiciones;
    [Space(10)]

    [Header("Cuchillo y Sangre")]
    public GameObject Cuchillo;
    public GameObject Sangre;
    [Space(10)]

    [Header("Sonidos")]
    public AudioClip Mesa;
    public AudioClip Mano;

    public static LanzarCuchilloSC instance;

	// Use this for initialization
	void Awake () {
        instance = this;
	}
	
	public void LanzarEnZona(int id_zona)
    {
        GameObject cuchillo = Instantiate(Cuchillo, Posiciones[id_zona].position, Cuchillo.transform.rotation);
        cuchillo.GetComponent<AudioSource>().clip = Mesa;
        cuchillo.GetComponent<AudioSource>().Play();
        Destroy(cuchillo, 0.8f);
    }

    public void LanzarMano(Vector3 pos)
    {
        GameObject cuchillo = Instantiate(Cuchillo, new Vector3(pos.x,4.0f,pos.z), Cuchillo.transform.rotation);
        Instantiate(Sangre, new Vector3(pos.x, 4.0f, pos.z), Sangre.transform.rotation);
        cuchillo.GetComponent<AudioSource>().clip = Mano;
        cuchillo.GetComponent<AudioSource>().Play();
        Destroy(cuchillo, 0.8f);
    }
}
