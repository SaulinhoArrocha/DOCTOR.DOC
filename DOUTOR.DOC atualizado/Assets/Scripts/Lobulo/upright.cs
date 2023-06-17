using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class upright : MonoBehaviour
{
    public GameObject campodeSenha;
    public GameObject acessoLobuloSD;

    public AudioClip somSenhaCorreta;
    public AudioClip somSenhaIncorreta;
    AudioSource emissorDeSom;

    //bool control = true; 
    string Code = "MEMBRANA"; 
    string Letra = null; 
    int LetraIndex = 0; 
    string Alpha; 
    public Text UiText = null; 
    [SerializeField] private Animator Door;

    private void Start()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
    }

    public void CodeFunction(string Letras)
    {
        LetraIndex++; 
        Letra = Letra + Letras; 
        UiText.text = Letra;  

    }
    public void Enter()
    {
        if (Letra == Code)
        {
            //campodeSenha.SetActive(false);
            if (somSenhaCorreta != null)
            {
                emissorDeSom.clip = somSenhaCorreta;
                emissorDeSom.PlayOneShot(emissorDeSom.clip);
            }

            UiText.text = "Correto"; 
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
            //control = false; 
            
            
             
        }
        else
        {
            if (somSenhaIncorreta != null)
            {
                emissorDeSom.clip = somSenhaIncorreta;
                emissorDeSom.PlayOneShot(emissorDeSom.clip);
            }

            UiText.text = "Incorreto!"; 

        }
    }
    public void Delete()
    {
        LetraIndex++; 
        Letra = null; 
        UiText.text = Letra;
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(1f); 
        Door.SetBool("Open", false);
        Door.enabled = false; 
        campodeSenha.SetActive(false);
        Destroy(acessoLobuloSD);
    }
}

