using UnityEngine;

public class WheelProvider : MonoBehaviour
{
    [SerializeField] private Transform _wheelTransform;
    [SerializeField] private WheelCollider _wheelCollider;
    [SerializeField] private bool _canSteer;
    
    private void Update()
    {
        UpdateView();
    }

    public void SetSteerAngle(float value)
    {
        if(!_canSteer)
            return;

        _wheelCollider.steerAngle = value;
    }

    public void SetMotorTorque(float value)
    {
        _wheelCollider.motorTorque = value;
    }

    public void SetBrakeTorque(float value)
    {
        _wheelCollider.brakeTorque = value;
    }

    private void UpdateView()
    {
        Vector3 position;
        Quaternion rotation;
        
        _wheelCollider.GetWorldPose(out position, out rotation);
        _wheelTransform.position = position;
        _wheelTransform.rotation = rotation;
    }
}
