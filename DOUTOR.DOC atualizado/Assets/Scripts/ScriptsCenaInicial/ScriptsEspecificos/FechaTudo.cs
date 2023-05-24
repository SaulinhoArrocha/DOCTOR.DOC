using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FechaTudo : MonoBehaviour
{
    public GameObject mala, inventario, manual, botaoManual;

    private void OnEnable()
    {
        mala.SetActive(false);
        inventario.SetActive(false);
        manual.SetActive(false);
        botaoManual.SetActive(false);
    }

    private void OnDisable()
    {
        mala.SetActive(true);
        botaoManual.SetActive(true);
    }
}
