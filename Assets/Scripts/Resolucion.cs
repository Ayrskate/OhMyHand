using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolucion : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Screen.SetResolution (1024, 600, true);
	}
}
