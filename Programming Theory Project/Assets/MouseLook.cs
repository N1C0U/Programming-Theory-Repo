using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Vector2 turn;
    public float sesitivity = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sesitivity;
        turn.y += Input.GetAxis("Mouse Y") * sesitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0 );
    }
}
