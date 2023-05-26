using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteAeD : MonoBehaviour
{
    // Start is called before the first frame update
    private RotacaoHorizontalInicial rotacaoHorizontal;
    private RotacaoVerticalInicial rotacaoVertical;
    public GameObject objetoWeS;


    private void OnEnable()
    {
        Destroy(objetoWeS);
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: false);
    }

    private void OnDisable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
    }
}
