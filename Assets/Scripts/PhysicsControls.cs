using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsControls : MonoBehaviour
{

    private Transform ThisTransform = null;
    private Rigidbody ShipBody = null;
    public float Speed = 1f;
    public string HorzAxis = "Horizontal";
    public string VertAxis = "Vertical";

    private void Awake()

    {
        ThisTransform = GetComponent<Transform>();
        ShipBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()

    {
        float Horz = Input.GetAxis(HorzAxis);
        float Vert = Input.GetAxis(VertAxis);

        Vector3 HorzVelocity = ThisTransform.right * Horz * Speed;
        Vector3 VertVelocity = ThisTransform.forward * Vert * Speed;

        ShipBody.velocity = HorzVelocity + VertVelocity;
    }

}
