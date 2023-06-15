using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColatarMoeda : MonoBehaviour
{
    public AudioClip somPegarMoeda;
    AudioSource emissorDeSom;


    public GameObject coim;
    public GameObject utilizar;
    public GameObject coimMala;
    public GameObject coletar;


    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;

    }


    private void OnMouseDown()
    {
        StartCoroutine("AbrirUtilizar");
    }


    IEnumerator AbrirUtilizar()
    {
        MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        if (somPegarMoeda != null)
        {
            emissorDeSom.clip = somPegarMoeda;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }                            

        Destroy(coim);
        Destroy(coletar);
        coimMala.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        utilizar.SetActive(true);
    }
}
