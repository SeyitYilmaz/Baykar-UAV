using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Plane : MonoBehaviour
{
    public Vector3 Velocity {  get;  set; }
    public Vector3 LocalVelocity { get;  set; }
    public Vector3 LocalAngularVelocity { get;  set; }
    public Vector3 LocalGForce { get;  set; }

    public float Throttle {  get;  set; }
    public float AngleOfAttack { get;  set; }
    public float AngleOfAttackYaw { get; set; }

    public AnimationCurve forwardDrag;
    public AnimationCurve backDrag;
    public AnimationCurve topDrag;
    public AnimationCurve bottomDrag;
    public AnimationCurve leftDrag;
    public AnimationCurve rightDrag;

}
