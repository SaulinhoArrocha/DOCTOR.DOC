using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    int zoom = 30;
    float smooth = 5;
    int normal = 90;
    bool canMakeZoom = true;

    private bool isZoomed = false;
    public GameObject ativaInventario;


    // Update is called once per frame
    void Update()
    {
        if (canMakeZoom)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                isZoomed = true;

            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                isZoomed = false;
            }

            if (isZoomed)
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
                ativaInventario.SetActive(false);


            }
            else
            {
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
                ativaInventario.SetActive(true);
            }
        }
    }

    public void CancelZoom(bool value)
    {
        canMakeZoom = value;
    }
}