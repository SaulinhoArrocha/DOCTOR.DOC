using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoMoeda : MonoBehaviour
{
    public AudioClip somUtilizarMoeda;
    AudioSource emissorDeSom;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }


    public GameObject acessoFlip;
    public GameObject utilizar;
    public GameObject efeitoFlip;
    public GameObject coimMala, coimCamera;

    private void OnMouseDown()
    {
        StartCoroutine("UtilizarMoeda");
    }

    IEnumerator UtilizarMoeda()
    {
        MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        if (somUtilizarMoeda != null)
        {
            emissorDeSom.clip = somUtilizarMoeda;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }

        efeitoFlip.SetActive(true);
        Destroy(utilizar);
        Destroy(coimMala);
        coimCamera.SetActive(false);
        acessoFlip.SetActive(true);

        yield return new WaitForSeconds(1f);

        Destroy(gameObject);

    }
}
