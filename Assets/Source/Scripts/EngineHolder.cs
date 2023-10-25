using System.Collections.Generic;
using TNRD;
using UnityEngine;

public class EngineHolder : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IInput> _input;
    [SerializeField] private List<WheelProvider> _wheels;
    [SerializeField] private float _motorForce;
    [SerializeField] private float _brakeForce;

    private void Update()
    {
        foreach (var wheel in _wheels)
        {
            wheel.SetMotorTorque(_input.Value.ThrottleValue() * _motorForce);
            wheel.SetBrakeTorque(_input.Value.HandBraking() ? _brakeForce : 0);
        }
    }
}
