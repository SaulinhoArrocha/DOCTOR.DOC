using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoTutorial : MonoBehaviour
{

    public GameObject robo1;
    public GameObject robo2;
    public GameObject inicio;
    public GameObject particulas;

    private void OnMouseDown()
    {
        StartCoroutine("AbrirTutorial");
    }

    IEnumerator AbrirTutorial()
    {
        Destroy(robo1);
        Destroy(particulas);
        yield return new WaitForSeconds(2f);
        robo2.SetActive(true);
        inicio.SetActive(true);
        gameObject.SetActive(false);
    }
}
