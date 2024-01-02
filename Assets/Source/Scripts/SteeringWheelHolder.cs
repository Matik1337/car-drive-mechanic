using System.Collections.Generic;
using TNRD;
using UnityEngine;

public class SteeringWheelHolder : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IInput> _input;
    [SerializeField] private List<WheelProvider> _wheels;
    [SerializeField] private float _maxSteerAngle;
    [SerializeField] private float _steerAngleChangeStep;

    private float _currentAngle;

    private void Update()
    {
        _currentAngle = Mathf.MoveTowards(_currentAngle, _input.Value.SteeringWheelValue * _maxSteerAngle,
            _steerAngleChangeStep * Time.deltaTime);
        
        foreach (var wheel in _wheels)
        {
            if(wheel.CanSteer)
                wheel.SetSteerAngle(_currentAngle);
        }
    }
}
