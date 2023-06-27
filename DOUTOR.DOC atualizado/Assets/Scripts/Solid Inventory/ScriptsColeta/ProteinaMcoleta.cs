using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMcoleta : MonoBehaviour
{
    public GameObject proteinaMmala;
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
        StartCoroutine("ColetarProteinaM");
    }

    IEnumerator ColetarProteinaM()
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

        proteinaMmala.SetActive(true);
        imagem.SetActive(true);

        yield return new WaitForSeconds(2f);

        Destroy(gameObject);
    }
}
