using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fechaManual : MonoBehaviour
{
    public GameObject manual, configuracao, painelConfiguracao;

    private void OnEnable()
    {
        manual.SetActive(false);
        configuracao.SetActive(false);
        painelConfiguracao.SetActive(false);
    }

    private void OnDisable()
    {
        manual.SetActive(true);
        configuracao.SetActive(true);
    }
}
