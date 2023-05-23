using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteWeS : MonoBehaviour
{
    private RotacaVertical rotacaoVertical;

    private void OnEnable()
    {
        rotacaoVertical = FindObjectOfType<RotacaVertical>();

        rotacaoVertical.CancelCameraVertical(value: true);
    }
}
