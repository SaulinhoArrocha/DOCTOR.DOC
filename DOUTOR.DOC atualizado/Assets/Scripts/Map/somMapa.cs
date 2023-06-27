using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class somMapa : MonoBehaviour
{
    public AudioClip somVirarMapa;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

        CheckMap.OnMapaGirou += VirouMapa;
    }

    public void VirouMapa()
    {
        if (somVirarMapa != null)
        {
            emissorDeSom.clip = somVirarMapa;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }
}
