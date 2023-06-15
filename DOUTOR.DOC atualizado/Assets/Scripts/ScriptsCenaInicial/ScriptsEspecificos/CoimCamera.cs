using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoimCamera : MonoBehaviour
{
    public GameObject acessoMoeda;
    public GameObject coimMala;

    private void OnEnable()
    {
        acessoMoeda.SetActive(true);
    }

    private void OnDisable()
    {
        coimMala.SetActive(true);
    }
}
