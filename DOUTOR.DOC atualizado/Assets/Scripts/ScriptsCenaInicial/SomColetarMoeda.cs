using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomColetarMoeda : MonoBehaviour
{
    public AudioClip somUtilizarMoeda;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

        AcessoMoeda.OnUsouMoeda += UtilizouMoeda;
    }

    public void UtilizouMoeda()
    {
        if (somUtilizarMoeda != null)
        {
            emissorDeSom.clip = somUtilizarMoeda;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }
}
