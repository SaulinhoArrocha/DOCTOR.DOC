using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelZoomeVerticalInicial : MonoBehaviour
{
    private RotacaoVerticalInicial rotacaoVertical;
    private CameraZoomInicial cameraZoom;


    private void OnEnable()
    {
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: false);
    }

    private void OnDisable()
    {
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);
    }
}
