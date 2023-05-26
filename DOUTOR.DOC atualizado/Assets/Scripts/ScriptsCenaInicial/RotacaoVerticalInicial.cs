using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoVerticalInicial : MonoBehaviour
{
    private Rigidbody Cabeca;
    public float verticalSpeed;
    [SerializeField()] Vector3 rotacion = new Vector3(0, 0, 0);
    bool canVerticalMove = false;

    // Start is called before the first frame update
    void Start()
    {
        Cabeca = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canVerticalMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(-verticalSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(verticalSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.rotation = Quaternion.Euler(rotacion);
            }
        }

    }

    public void CancelCameraVertical(bool value)
    {
        canVerticalMove = value;
    }
}
