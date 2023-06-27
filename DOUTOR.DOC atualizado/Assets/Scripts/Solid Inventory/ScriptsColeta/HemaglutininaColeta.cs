using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemaglutininaColeta : MonoBehaviour
{
    public GameObject hemaglutininaMala;
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
        StartCoroutine("ColetarHemaglu");
    }

    IEnumerator ColetarHemaglu()
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

        hemaglutininaMala.SetActive(true);
        imagem.SetActive(true);

        yield return new WaitForSeconds(2f);

        Destroy(gameObject);
    }
}
