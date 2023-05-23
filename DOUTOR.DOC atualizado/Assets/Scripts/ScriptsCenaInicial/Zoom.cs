using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject zoom;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            zoom.SetActive(false); ;
        }
    }
}
