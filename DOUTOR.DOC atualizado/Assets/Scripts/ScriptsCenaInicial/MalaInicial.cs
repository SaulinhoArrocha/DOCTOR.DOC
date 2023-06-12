using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalaInicial : MonoBehaviour
{
    public GameObject botaoInventario;
    public GameObject setaInventario;
    public GameObject manualFinal;
    public GameObject setaManual;
    public GameObject manualInicial;
    public GameObject coleta;
    public GameObject manualAtual;

    public void FecharBotaoInventario()
    {
        Destroy(botaoInventario);
        Destroy(setaInventario);
        Destroy(manualInicial);
        manualFinal.SetActive(true);
        setaManual.SetActive(true);
    }
    
    public void chamaAbreColeta()
    {
        StartCoroutine("AbrirColeta");
    }

    IEnumerator AbrirColeta()
    {
        Destroy(manualAtual);
        yield return new WaitForSeconds(1.5f);
        coleta.SetActive(true);

    }
}
