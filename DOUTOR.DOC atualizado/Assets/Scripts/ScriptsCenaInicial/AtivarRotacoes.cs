using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarRotacoes : MonoBehaviour
{
    private RotacaoHorizontalInicial rotacaoHorizontal;
    private RotacaoVerticalInicial rotacaoVertical;
    private CameraZoomInicial cameraZoom;


    private void OnEnable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);
    }

}
