using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColatarMoeda : MonoBehaviour
{
    public GameObject coim;
    public GameObject utilizar;
    public GameObject coimMala;
    public GameObject coletar;

    private void OnMouseDown()
    {
        StartCoroutine("AbrirUtilizar");
    }


    IEnumerator AbrirUtilizar()
    {
        Destroy(coim);
        Destroy(coletar);
        coimMala.SetActive(true);
        yield return new WaitForSeconds(8);
        utilizar.SetActive(true);
    }
}
