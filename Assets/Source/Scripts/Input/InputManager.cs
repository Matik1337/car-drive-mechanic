using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool HandBraking { get; protected set; }
    public float ThrottleValue { get; protected set; }
    public float SteeringWheelValue { get; protected set; }
}
