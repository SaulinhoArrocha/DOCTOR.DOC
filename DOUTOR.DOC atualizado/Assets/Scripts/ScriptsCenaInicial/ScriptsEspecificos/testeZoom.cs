using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeZoom : MonoBehaviour
{
    private RotacaoHorizontalInicial rotacaoHorizontal;
    private RotacaoVerticalInicial rotacaoVertical;
    private CameraZoomInicial cameraZoom;
    public GameObject objetoAeD;



    private void OnEnable()
    {
        Destroy(objetoAeD);
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontalInicial>();
        rotacaoVertical = FindObjectOfType<RotacaoVerticalInicial>();
        cameraZoom = FindObjectOfType<CameraZoomInicial>();

        rotacaoHorizontal.CancelCamera(value: false);
        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: true);
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
