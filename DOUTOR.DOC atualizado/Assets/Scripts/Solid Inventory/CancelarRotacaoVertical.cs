using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelarRotacaoVertical : MonoBehaviour
{
    private RotacaVertical rotacaoVertical;
    private CameraZoom cameraZoom;

    private void OnEnable()
    {
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: false);
    }

    private void OnDisable()
    {
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);
    }
}
