using UnityEngine;

public class DesktopInput : IInput
{
    public bool HandBraking()
    {
        return Input.GetKey(KeyCode.Space);
    }

    public float ThrottleValue()
    {
        return Input.GetAxis("Vertical");
    }

    public float SteeringWheelValue()
    {
        return Input.GetAxis("Horizontal");
    }
}
