using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouPS : MonoBehaviour
{
    public GameObject psMala, psFinal, psCamera;

    public delegate void UsarPS();
    public static event UsarPS OnUsouPS;


    void OnMouseDown()
    {
        if (OnUsouPS != null)
        {
            OnUsouPS();
        }

        StartCoroutine("ProteinaSP");
    }

    IEnumerator ProteinaSP()
    {
        Destroy(psMala);
        psCamera.SetActive(false);
        psFinal.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}
