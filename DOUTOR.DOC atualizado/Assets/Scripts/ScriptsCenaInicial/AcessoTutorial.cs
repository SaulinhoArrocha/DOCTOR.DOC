using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoTutorial : MonoBehaviour
{

    public GameObject robo;
    public GameObject inicio;
    public GameObject particulas;

    private void OnMouseDown()
    {
        StartCoroutine("AbrirTutorial");
    }

    IEnumerator AbrirTutorial()
    {
        Destroy(robo);
        Destroy(particulas);
        yield return new WaitForSeconds(2f);
        inicio.SetActive(true);
        gameObject.SetActive(false);
    }
}
