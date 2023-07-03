using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarVacina : MonoBehaviour
{
    public LevelLoader LevelLoader;
    public GameObject vacinaMala, vacinaCamera;

    public AudioClip somPortal;
    AudioSource emissorDeSom;


    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    private void OnMouseDown()
    {
        if (somPortal != null)
        {
            emissorDeSom.clip = somPortal;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        Destroy(vacinaMala);
        Destroy(vacinaCamera);

        LevelLoader.Transition("Final");
    }

}
