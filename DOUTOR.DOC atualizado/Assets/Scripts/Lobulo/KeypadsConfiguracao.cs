using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadsConfiguracao : MonoBehaviour
{
    public GameObject configuracao, configuracoes, painelConfiguracao;

    private void OnEnable()
    {
        configuracoes.SetActive(false);
        painelConfiguracao.SetActive(false);
    }

    private void OnDisable()
    {
        configuracoes.SetActive(true);
        configuracao.SetActive(true);
    }
}
