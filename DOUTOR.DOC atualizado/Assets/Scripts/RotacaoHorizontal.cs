using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoHorizontal : MonoBehaviour
{
    private Rigidbody player;
    public float RotSpeed;
    bool canHorizontalMove = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canHorizontalMove)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -RotSpeed, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, RotSpeed, 0);
            }
        }
    }

    public void CancelCamera(bool value)
    {
        canHorizontalMove = value;
    }
}
