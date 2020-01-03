using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloquearNivelSC : MonoBehaviour {

    [Header("Parametros")]
    public string NivelesPP = "";
    public int esteNivel;
    public GameObject Candado;

    Button btn;

    //Si el dato nivelespp es igual o mayor que el id que tiene el objeto se desbloquea
    private void Awake()
    {
        btn = GetComponent<Button>();

        if (PlayerPrefs.GetInt(NivelesPP) >= esteNivel)
        {
            btn.interactable = true;
            Candado.SetActive(false);
        }
        else
        {
            btn.interactable = false;
            Candado.SetActive(true);
        }
    }
}
