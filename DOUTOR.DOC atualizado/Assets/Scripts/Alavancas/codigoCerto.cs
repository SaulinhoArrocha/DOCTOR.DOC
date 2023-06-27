using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoCerto : MonoBehaviour
{
    [SerializeField] private Animator Mesa;

    public AudioClip somMesa;
    AudioSource emissorDeSom;


    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

    }

    void girarMesa()
    {
        if (somMesa != null)
        {
            emissorDeSom.clip = somMesa;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        Mesa.SetBool("Open", true);
        StartCoroutine("StopMesa");
    }

    IEnumerator StopMesa()
    {
        yield return new WaitForSeconds(2f); 
        Mesa.SetBool("Open", false);
        Mesa.enabled = false; 
    }

    
}
