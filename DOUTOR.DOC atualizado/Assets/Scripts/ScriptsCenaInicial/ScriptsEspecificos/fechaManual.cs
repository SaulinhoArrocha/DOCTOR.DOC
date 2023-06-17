using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fechaManual : MonoBehaviour
{
    public GameObject manual;

    private void OnEnable()
    {
        manual.SetActive(false);
    }

    private void OnDisable()
    {
        manual.SetActive(true);
    }
}
