using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouEnvelopeC : MonoBehaviour
{
    public GameObject envelopeCMala, envelopeCFinal, envelopeCCamera;

    public delegate void UsarEnvelopeC();
    public static event UsarEnvelopeC OnUsouEnvelopeC;

    void OnMouseDown()
    {
        if (OnUsouEnvelopeC != null)
        {
            OnUsouEnvelopeC();
        }

        StartCoroutine("EnvelopeC");
    }

    IEnumerator EnvelopeC()
    {
        Destroy(envelopeCMala);
        envelopeCCamera.SetActive(false);
        envelopeCFinal.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}
