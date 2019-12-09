using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick movementJoystick;
    public Joystick rotationJoystick;
    public float runSpeed = 3.5f, horizontalRotateSpeed = 100f, verticalRotateSpeed = 50f;
    public Camera cam;

    Vector3 rot;

    void Update()
    {
        rot += new Vector3(-rotationJoystick.Vertical * verticalRotateSpeed, rotationJoystick.Horizontal * horizontalRotateSpeed, 0f) * Time.deltaTime;
        rot.x = Mathf.Clamp(rot.x, -50f, 70f);
        transform.position += transform.TransformDirection(new Vector3(movementJoystick.Horizontal, 0f, movementJoystick.Vertical) * runSpeed * Time.deltaTime);
        //transform.rotation *= Quaternion.Euler(0f , movementJoystick.Horizontal * rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        cam.transform.localRotation = Quaternion.Euler(rot.x, 0f, 0f);
    }
}
