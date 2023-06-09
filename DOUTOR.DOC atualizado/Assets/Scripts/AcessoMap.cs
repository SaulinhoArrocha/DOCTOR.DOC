using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoMap : MonoBehaviour
{
    public GameObject Map;

    public AudioClip somAbrirMapa;
    AudioSource emissorDeSom;

    private void Start()
    {

        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    private void OnMouseDown()
    {
        if (somAbrirMapa != null)
        {
            emissorDeSom.clip = somAbrirMapa;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        Map.SetActive(true);
    }
}
