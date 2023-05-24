using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalaeManual : MonoBehaviour
{
    public GameObject testeColeta;

    public GameObject malaeManual;


    public void AbreColeta()
    {
        StartCoroutine("AbrirColeta");
    }

    IEnumerator AbrirColeta()
    {
        Destroy(malaeManual);
        yield return new WaitForSeconds(8);
        testeColeta.SetActive(true);
    }
}
