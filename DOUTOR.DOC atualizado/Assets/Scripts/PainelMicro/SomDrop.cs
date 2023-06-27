using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomDrop : MonoBehaviour
{
    public AudioClip somDrop;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

        AcertouPS.OnUsouPS += DropPS;
        AcertouRna.OnUsouRna += DropRna;
        AcertouEnvelopeC.OnUsouEnvelopeC += DropEnvelope;
        AcertouPM.OnUsouPM += DropPM;
        AcertouHemaglu.OnUsouHemaglu += DropHemaglu;
    }

    public void DropHemaglu ()
    {
        if (somDrop != null)
        {
            emissorDeSom.clip = somDrop;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }

    public void DropEnvelope()
    {
        if (somDrop != null)
        {
            emissorDeSom.clip = somDrop;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }

    public void DropRna()
    {
        if (somDrop != null)
        {
            emissorDeSom.clip = somDrop;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }

    public void DropPM()
    {
        if (somDrop != null)
        {
            emissorDeSom.clip = somDrop;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }

    public void DropPS()
    {
        if (somDrop != null)
        {
            emissorDeSom.clip = somDrop;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }
}
