using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
    bool mouseDentroDoObjeto; 
    public GameObject colunas;

    public AudioClip somGirarColunas;
    AudioSource emissorDeSom;

    void Start()
    {
        mouseDentroDoObjeto = false;

        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (somGirarColunas != null)
                {
                    emissorDeSom.clip = somGirarColunas;
                    emissorDeSom.PlayOneShot(emissorDeSom.clip);
                }

                colunas.transform.Rotate (0, 90, 0); 
  
            }

        }
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
