using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoMoeda : MonoBehaviour
{

    public GameObject acessoFlip;
    public GameObject utilizar;
    public GameObject efeitoFlip;
    public GameObject coimMala, coimCamera;

    public delegate void UsarMoeda();
    public static event UsarMoeda OnUsouMoeda;

    private void OnMouseDown()
    {
        if (OnUsouMoeda != null)
        {
            OnUsouMoeda();
        }

        StartCoroutine("UtilizarMoeda");
    }

    IEnumerator UtilizarMoeda()
    {
        efeitoFlip.SetActive(true);
        Destroy(utilizar);
        Destroy(coimMala);
        coimCamera.SetActive(false);
        acessoFlip.SetActive(true);

        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);

    }
}
