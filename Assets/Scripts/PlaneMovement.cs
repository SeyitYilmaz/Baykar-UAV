using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    private Rigidbody planeRigidbody;
    Plane currentPlane;
    Vector3 previousVelocity;
    void Awake()
    {
        planeRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        currentPlane = GetComponent<Plane>();
    }

    void CalculatePlaneState(float deltaTime)
    {
        var inverseRotation = Quaternion.Inverse(planeRigidbody.rotation);
        currentPlane.Velocity = planeRigidbody.velocity;
        currentPlane.LocalVelocity = inverseRotation * currentPlane.Velocity;
        currentPlane.LocalAngularVelocity = inverseRotation * planeRigidbody.angularVelocity;

        CalculateAngleOfAttack();
    }
    void CalculateAngleOfAttack () 
    {
        if(currentPlane.LocalVelocity.sqrMagnitude < 0.1f)
        {
            currentPlane.AngleOfAttack = 0;
            currentPlane.AngleOfAttackYaw = 0;
            return;
        }
        currentPlane.AngleOfAttack = Mathf.Atan2(-currentPlane.LocalVelocity.y, currentPlane.LocalVelocity.z);
        currentPlane.AngleOfAttackYaw = Mathf.Atan2(currentPlane.LocalVelocity.x, currentPlane.LocalVelocity.z);
    }
    void CalculateGForce(float deltaTime)
    {
        var inverseRotation = Quaternion.Inverse(planeRigidbody.rotation);
        var acceleration = (currentPlane.Velocity - previousVelocity) / deltaTime;
        currentPlane.LocalGForce = inverseRotation * acceleration;
        previousVelocity = currentPlane.Velocity;
    }

    public Vector3 Scale6(Vector3 value , float posX, float negX,float posY, float negY, float posZ, float negZ)
    {
        Vector3 result = value;
        return result;
    }

}
