using UnityEngine;

public class DesktopInput : IInput
{
    public bool HandBraking => Input.GetKey(KeyCode.Space);
    public float ThrottleValue => Input.GetAxis("Vertical");
    public float SteeringWheelValue => Input.GetAxis("Horizontal");
}
