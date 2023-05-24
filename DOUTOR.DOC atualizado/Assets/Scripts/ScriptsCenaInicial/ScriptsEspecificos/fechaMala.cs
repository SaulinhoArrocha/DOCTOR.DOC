using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fechaMala : MonoBehaviour
{
    public GameObject mala;

    private void OnEnable()
    {
        mala.SetActive(false);
    }

    private void OnDisable()
    {
        mala.SetActive(true);
    }
}
