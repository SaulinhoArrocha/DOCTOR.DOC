using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fechaMala : MonoBehaviour
{
    public GameObject mala, configuracao, painelConfiguracao;

    private void OnEnable()
    {
        mala.SetActive(false);
        configuracao.SetActive(false);
        painelConfiguracao.SetActive(false);
    }

    private void OnDisable()
    {
        mala.SetActive(true);
        configuracao.SetActive(true);
    }
}
