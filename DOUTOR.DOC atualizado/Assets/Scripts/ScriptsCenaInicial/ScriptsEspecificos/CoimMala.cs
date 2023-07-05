using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoimMala : MonoBehaviour
{
    public GameObject coimCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        coimCamera.SetActive(true);

    }
}
