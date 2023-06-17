using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarConfiguracao : MonoBehaviour
{
    public GameObject configuracao, painelConfiguracao;

    private void OnEnable()
    {
        configuracao.SetActive(false);
        painelConfiguracao.SetActive(false);
    }

    private void OnDisable()
    {
        configuracao.SetActive(true);
    }
}
