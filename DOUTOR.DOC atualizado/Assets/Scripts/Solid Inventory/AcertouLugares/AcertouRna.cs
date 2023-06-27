using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouRna : MonoBehaviour
{
    public GameObject rnaMala, rnaFinal, rnaCamera;

    public delegate void UsarRna();
    public static event UsarRna OnUsouRna;

    void OnMouseDown()
    {
        if (OnUsouRna != null)
        {
            OnUsouRna();
        }

        StartCoroutine("Rna");
    }

    IEnumerator Rna()
    {
        Destroy(rnaMala);
        rnaCamera.SetActive(false);
        rnaFinal.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}
