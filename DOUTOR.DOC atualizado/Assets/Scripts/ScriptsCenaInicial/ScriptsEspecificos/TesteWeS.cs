using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteWeS : MonoBehaviour
{
    private RotacaoVerticalInicial rotacaoVertical;

    private void OnEnable()
    {
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();

        rotacaoVertical.CancelCameraVertical(value: true);
    }
}
