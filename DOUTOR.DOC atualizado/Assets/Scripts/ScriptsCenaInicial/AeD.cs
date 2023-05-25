using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeD : MonoBehaviour
{
    public GameObject testeZoom;

    public GameObject aed;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine("AbrirZoom");
        }
    }


    IEnumerator AbrirZoom()
    {
        Destroy(aed);
        yield return new WaitForSeconds(3);
        testeZoom.SetActive(true);
    }
}
