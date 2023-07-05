using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaNova : MonoBehaviour
{
    public AudioClip somPegarMoeda;
    AudioSource emissorDeSom;


    public GameObject coim;
    public GameObject coimMala;


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
        coimMala.SetActive(true);

        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }
}
