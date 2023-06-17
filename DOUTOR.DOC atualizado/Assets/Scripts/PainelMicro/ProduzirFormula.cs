using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduzirFormula : MonoBehaviour
{
    public GameObject painelMicroscopio;
    public GameObject amostra;
    [Range(0.1f, 5.0f)] public float tempo = 1;

    public AudioClip somProduzirVacina;
    AudioSource emissorDeSom;


    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

    }

    public void Produzir()
    {
        StartCoroutine("ProducaoFarmaco");
    }

    IEnumerator ProducaoFarmaco()
    {
        if (amostra != null && painelMicroscopio != null)
        {
            if (somProduzirVacina != null)
            {
                emissorDeSom.clip = somProduzirVacina;
                emissorDeSom.PlayOneShot(emissorDeSom.clip);
            }

            painelMicroscopio.SetActive(false);
            yield return new WaitForSeconds(tempo);
            amostra.SetActive(true);
        }
    }
}
