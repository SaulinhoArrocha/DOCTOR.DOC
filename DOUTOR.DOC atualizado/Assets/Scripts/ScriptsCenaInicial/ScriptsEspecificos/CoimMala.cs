using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoimMala : MonoBehaviour
{
    public GameObject moeda;
    public GameObject coimCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        moeda.SetActive(false);
        coimCamera.SetActive(true);

    }
}
