using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject testeMalaeManual;

    public GameObject zoom;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine("AbrirMalaeManual");
        }
    }


    IEnumerator AbrirMalaeManual()
    {
        Destroy(zoom);
        yield return new WaitForSeconds(4);
        testeMalaeManual.SetActive(true);
    }
}
