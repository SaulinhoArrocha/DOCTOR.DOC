using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomQuadro : MonoBehaviour
{
    public AudioClip somQuadro;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

        AcertouRetrato.OnQuadroAbriu += ArmarioAbriu;
    }

    public void ArmarioAbriu()
    {
        if (somQuadro != null)
        {
            emissorDeSom.clip = somQuadro;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
    }
}
