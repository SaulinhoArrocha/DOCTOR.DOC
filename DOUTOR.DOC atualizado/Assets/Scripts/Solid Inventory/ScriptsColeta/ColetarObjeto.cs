using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarObjeto : MonoBehaviour
{
    public GameObject ativarObjeto;
    public GameObject imagem;

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
        StartCoroutine("Coletar");
    }

    IEnumerator Coletar()
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

        ativarObjeto.SetActive(true);
        imagem.SetActive(true);

        yield return new WaitForSeconds(1.3f);

        Destroy(gameObject);
    }
}
