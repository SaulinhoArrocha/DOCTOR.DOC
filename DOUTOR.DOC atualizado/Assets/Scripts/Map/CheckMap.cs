using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMap : MonoBehaviour
{
    public GameObject Origem;
    public GameObject Vacina;
    public GameObject Lockdown;
    public GameObject Mortes;
    public GameObject China;
    public GameObject ReinoUnido;
    public GameObject Vietna; 
    public GameObject Usa;
    public GameObject Map; 
    public GameObject Box; 
    [SerializeField] private Animator Lousa;

    public delegate void GirarMapa();
    public static event GirarMapa OnMapaGirou;



    // Update is called once per frame
    void Update()
    {
         if((Origem.transform.position == China.transform.position) && (Vacina.transform.position == ReinoUnido.transform.position) &&
        (Lockdown.transform.position == Vietna.transform.position) && (Mortes.transform.position == Usa.transform.position) )
        {
            if (OnMapaGirou != null)
            {
                OnMapaGirou();
            }

            Map.SetActive(false); 
            Box.SetActive(true); 
            Lousa.SetBool("Rotate", true); 

        }
        
    }
}
