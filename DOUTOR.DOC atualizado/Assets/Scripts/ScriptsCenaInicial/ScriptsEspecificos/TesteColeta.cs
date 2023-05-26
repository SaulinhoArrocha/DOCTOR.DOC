using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteColeta : MonoBehaviour
{
    private RotacaoHorizontalInicial rotacaoHorizontal;
    private RotacaoVerticalInicial rotacaoVertical;
    private CameraZoomInicial cameraZoom;
    public GameObject objetoMalaeManual;



    private void OnEnable()
    {
        Destroy(objetoMalaeManual);
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoHorizontal.CancelCamera(value: false);
        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: false);
    }

    private void OnDisable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);

    }
}
