using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public AudioClip somInfectado;
    public AudioClip somVencedorPuzzleOne;
    AudioSource emissorDeSom;

    public Transform pauseMenu;
    public Transform vencedor;

    // Start is called before the first frame update
    void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if((other.name == "Saulo") || (other.name == "Carlos") || (other.name == "Joao") || (other.name == "Lilian") || (other.name == "Isabele") || (other.name == "Kleberson") || (other.name == "Matias") || (other.name == "Paulo"))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                if (somInfectado != null)
                {
                    emissorDeSom.clip = somInfectado;
                    emissorDeSom.PlayOneShot(emissorDeSom.clip);
                }

                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;

            }
        }
        else if(other.name == "Destino")
        {
            if (vencedor.gameObject.activeSelf)
            {
                vencedor.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                if (somVencedorPuzzleOne != null)
                {
                    emissorDeSom.clip = somVencedorPuzzleOne;
                    emissorDeSom.PlayOneShot(emissorDeSom.clip);
                }

                vencedor.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
