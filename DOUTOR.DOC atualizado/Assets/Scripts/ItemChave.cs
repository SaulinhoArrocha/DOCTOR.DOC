using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ItemChave : MonoBehaviour
{

    //variáveis;

    bool mouseDentroDoObjeto;

    public int IDDestaChave = 0;
    [Range(0.1f, 80.0f)] public float distanciaDaChave = 3;
    public AudioClip somPegarChave;
    AudioSource emissorDeSom;
    GameObject Jogador;
    Chaves _listaDeChaves;
    bool jaPegou;

    public GameObject chaveMala;
    public GameObject imagem;

    // Start is called before the first frame update
    void Start()
    {
        mouseDentroDoObjeto = false;
        jaPegou = false;
        Jogador = GameObject.FindWithTag("Player");
        if (Jogador != null)
        {
            _listaDeChaves = Jogador.GetComponent<Chaves>();
        }
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jogador != null && _listaDeChaves != null)
        {
            if (jaPegou == false)
            {
                float distancia = Vector3.Distance(Jogador.transform.position, transform.position);
                if (distancia < distanciaDaChave)
                {
                    if (mouseDentroDoObjeto == true)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            _listaDeChaves.ChavesDoJogador.Add(IDDestaChave);
                            jaPegou = true;
                            StartCoroutine("DestruirObjeto");
                        }

                    }
                }
            }
        }
    }

    private IEnumerator DestruirObjeto()
    {
        MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        if (somPegarChave != null)
        {
            emissorDeSom.clip = somPegarChave;
            emissorDeSom.PlayOneShot(emissorDeSom.clip);
        }
        yield return new WaitForSeconds(1f);

        chaveMala.SetActive(true);
        Destroy(gameObject);
        imagem.SetActive(true);

    }

    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }
    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}

