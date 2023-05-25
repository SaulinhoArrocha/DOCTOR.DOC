using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharInventario : MonoBehaviour
{
    public GameObject coimCamera;

    private void OnDisable()
    {
        coimCamera.SetActive(false);
    }
}
