using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelarRotacaoVertical : MonoBehaviour
{
    private RotacaVertical rotacaoVertical;

    private void OnEnable()
    {
        rotacaoVertical = FindObjectOfType<RotacaVertical>();

        rotacaoVertical.CancelCameraVertical(value: false);
    }

    private void OnDisable()
    {
        rotacaoVertical = FindObjectOfType<RotacaVertical>();

        rotacaoVertical.CancelCameraVertical(value: true);
    }
}
