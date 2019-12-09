using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public Joystick joystickR;

    private void Update()
    {
        this.transform.Rotate(new Vector3(-joystickR.Vertical, joystickR.Horizontal, 0f),rotateSpeed);
    }
}
