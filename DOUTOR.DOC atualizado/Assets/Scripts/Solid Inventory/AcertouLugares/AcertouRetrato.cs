using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouRetrato : MonoBehaviour
{
    public GameObject retratoMala, retratoFinal, rretratoCamera;
    [SerializeField] private Animator PortaArmario;

    public delegate void AbrirQuadro();
    public static event AbrirQuadro OnQuadroAbriu;

    private void OnMouseDown()
    {
        if(OnQuadroAbriu != null)
        {
            OnQuadroAbriu();
        }

        Destroy(gameObject);
        Destroy(retratoMala);
        rretratoCamera.SetActive(false);
        retratoFinal.SetActive(true);
        PortaArmario.SetBool("Open", true); 

    }
}
