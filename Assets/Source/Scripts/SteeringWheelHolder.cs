using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelHolder : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private List<WheelProvider> _wheels;
    [SerializeField] private float _maxSteerAngle;
    [SerializeField] private float _steerAngleChangeStep;

    private float _currentAngle;

    private void Update()
    {
        _currentAngle = Mathf.MoveTowards(_currentAngle, _inputManager.SteeringWheelValue * _maxSteerAngle,
            _steerAngleChangeStep * Time.deltaTime);
        
        foreach (var wheel in _wheels)
        {
            wheel.SetSteerAngle(_currentAngle);
        }
    }
}
