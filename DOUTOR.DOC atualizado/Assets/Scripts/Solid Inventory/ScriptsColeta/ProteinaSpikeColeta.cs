using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaSpikeColeta : MonoBehaviour
{
    public GameObject proteinaSpikeMala;
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
        StartCoroutine("ColetarProteinaSP");
    }

    IEnumerator ColetarProteinaSP()
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

        proteinaSpikeMala.SetActive(true);
        imagem.SetActive(true);

        yield return new WaitForSeconds(2f);

        Destroy(gameObject);
    }
}
