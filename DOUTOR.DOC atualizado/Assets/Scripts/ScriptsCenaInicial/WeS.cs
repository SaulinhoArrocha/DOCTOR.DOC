using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeS : MonoBehaviour
{
    public GameObject testeAeD;

    public GameObject wes;

    public GameObject objetoAeD;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine("AbrirAeD");
        }
    }


    IEnumerator AbrirAeD()
    {
        Destroy(wes);
        yield return new WaitForSeconds(3);
        testeAeD.SetActive(true);
        objetoAeD.SetActive(true);
    }
}
