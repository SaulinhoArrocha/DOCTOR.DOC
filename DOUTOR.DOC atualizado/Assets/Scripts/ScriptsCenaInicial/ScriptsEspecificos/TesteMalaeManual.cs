using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMalaeManual : MonoBehaviour
{
    private RotacaoHorizontal rotacaoHorizontal;
    private RotacaVertical rotacaoVertical;
    private CameraZoom cameraZoom;
    public GameObject objetoZoom;
    public GameObject manual;
    public GameObject mala;



    private void OnEnable()
    {
        Destroy(objetoZoom);
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: false);
        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: false);
    }

    private void OnDisable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);

        manual.SetActive(true);
        mala.SetActive(true);
    }
}
