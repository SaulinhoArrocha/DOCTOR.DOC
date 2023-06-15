using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoFliperama : MonoBehaviour
{
    public AudioClip somAbrirFlip;
    AudioSource emissorDeSom;

    bool mouseDentroDoObjeto;
    public string sceneName;

    public LevelLoader levelLoader;

    // Start is called before the first frame update
    void Start()
    {
        mouseDentroDoObjeto = false;
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (somAbrirFlip != null)
                {
                    emissorDeSom.clip = somAbrirFlip;
                    emissorDeSom.PlayOneShot(emissorDeSom.clip);
                }

                levelLoader.Transition(sceneName);
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
