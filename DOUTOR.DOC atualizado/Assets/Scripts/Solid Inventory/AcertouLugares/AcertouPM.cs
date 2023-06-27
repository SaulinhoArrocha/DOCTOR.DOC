using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouPM : MonoBehaviour
{
    public GameObject pmMala, pmFinal, pmCamera;

    public delegate void UsarPM();
    public static event UsarPM OnUsouPM;

    void OnMouseDown()
    {
        if (OnUsouPM != null)
        {
            OnUsouPM();
        }

        StartCoroutine("ProteinaM");
    }

    IEnumerator ProteinaM()
    {
        Destroy(pmMala);
        pmCamera.SetActive(false);
        pmFinal.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}
