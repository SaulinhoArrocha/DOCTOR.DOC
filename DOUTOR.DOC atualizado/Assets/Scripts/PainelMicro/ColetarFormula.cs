using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarFormula : MonoBehaviour
{
    public GameObject amostraMala;
    public GameObject imagem;
    public GameObject portal;
    public GameObject luzPortal;
    public GameObject botaoPortal;

    public AudioClip somColetar;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

    }

    void OnMouseDown()
    {
        StartCoroutine("ColetarAntidoto");
    }

    IEnumerator ColetarAntidoto()
    {
        MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        if (somColetar != null)
        {
            emissorDeSom.clip = somColetar;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        amostraMala.SetActive(true);
        imagem.SetActive(true);
        portal.SetActive(true);
        luzPortal.SetActive(true);
        botaoPortal.SetActive(true);

        yield return new WaitForSeconds(1.3f);

        Destroy(gameObject);
    }
}
