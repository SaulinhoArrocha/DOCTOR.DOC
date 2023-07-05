using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PularTutorial : MonoBehaviour
{
    public GameObject robo1;
    public GameObject robo2;
    public GameObject inicio;
    public GameObject setaInventario, setaManual;
    public GameObject tutorial;
    public GameObject inventarioInicial;
    public GameObject manualInicial;
    public GameObject moedaAntiga;
    public GameObject moedaNova;


    public void DestruirObjetos()
    {
        Destroy(robo1);
        Destroy(robo2);
        Destroy(inicio);
        Destroy(setaInventario);
        Destroy(setaManual);
        Destroy(tutorial);
        Destroy(inventarioInicial);
        Destroy(manualInicial);
        Destroy(moedaAntiga);
        moedaNova.SetActive(true);
    }
}
