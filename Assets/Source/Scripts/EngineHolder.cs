using System.Collections.Generic;
using UnityEngine;

public class EngineHolder : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private List<WheelProvider> _wheels;
    [SerializeField] private float _motorForce;
    [SerializeField] private float _brakeForce;

    private void Update()
    {
        foreach (var wheel in _wheels)
        {
            wheel.SetMotorTorque(_inputManager.ThrottleValue * _motorForce);
            wheel.SetBrakeTorque(_inputManager.HandBraking ? _brakeForce : 0);
        }
    }
}
