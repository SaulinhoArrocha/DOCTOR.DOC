using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouHemaglu : MonoBehaviour
{
    public GameObject hemagluMala, hemagluFinal, hemagluCamera;

    public delegate void UsarHemaglu();
    public static event UsarHemaglu OnUsouHemaglu;

    void OnMouseDown()
    {
        if (OnUsouHemaglu != null)
        {
            OnUsouHemaglu();
        }

        StartCoroutine("Hemaglu");
    }

    IEnumerator Hemaglu()
    {
        Destroy(hemagluMala);
        hemagluCamera.SetActive(false);
        hemagluFinal.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }
}
