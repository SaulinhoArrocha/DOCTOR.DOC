using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeZoom : MonoBehaviour
{
    private RotacaoHorizontal rotacaoHorizontal;
    private RotacaVertical rotacaoVertical;
    private CameraZoom cameraZoom;
    public GameObject objetoAeD;



    private void OnEnable()
    {
        Destroy(objetoAeD);
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: false);
        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: true);
    }

    private void OnDisable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);
    }
}
