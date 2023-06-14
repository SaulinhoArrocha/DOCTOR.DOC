using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMalaeManual : MonoBehaviour
{
    private RotacaoHorizontalInicial rotacaoHorizontal;
    private RotacaoVerticalInicial rotacaoVertical;
    private CameraZoomInicial cameraZoom;
    public GameObject objetoZoom;
    public GameObject manual;
    public GameObject mala;
    public GameObject setaInventario;



    private void OnEnable()
    {
        Destroy(objetoZoom);
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

        manual.SetActive(true);
        setaInventario.SetActive(true);
        mala.SetActive(true);
    }
}
