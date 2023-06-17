using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AtivarObjetos : MonoBehaviour
{
    public AudioClip somAbrirMicros;
    AudioSource emissorDeSom;

    public GameObject ativado, formula;

    public Transform rna;
    public Transform hemaglu;
    public Transform proteinaSP;
    public Transform proteinaM;
    public Transform envelope;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

    }

    private void OnMouseDown(){

        if (somAbrirMicros != null)
        {
            emissorDeSom.clip = somAbrirMicros;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        ativado.SetActive(true);

        if ((rna.gameObject.activeSelf) && (hemaglu.gameObject.activeSelf) && (proteinaSP.gameObject.activeSelf) && (proteinaM.gameObject.activeSelf) && (envelope.gameObject.activeSelf))
        {
            formula.SetActive(true);
        }
    }
}
