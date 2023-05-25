using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoMoeda : MonoBehaviour
{
    public GameObject acessoFlip;
    public GameObject utilizar;
    public GameObject efeitoFlip;
    public GameObject coimMala, coimCamera;

    private void OnMouseDown()
    {
        efeitoFlip.SetActive(true);
        Destroy(utilizar);
        Destroy(coimMala);
        coimCamera.SetActive(false);
        acessoFlip.SetActive(true);
        Destroy(gameObject);
    }
}
