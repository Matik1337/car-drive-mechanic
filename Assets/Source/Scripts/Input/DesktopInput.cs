using UnityEngine;

public class DesktopInput : InputManager
{
    private void Update()
    {
        HandBraking = Input.GetKey(KeyCode.Space);
        ThrottleValue = Input.GetAxis("Vertical");
        SteeringWheelValue = Input.GetAxis("Horizontal");
    }
}
