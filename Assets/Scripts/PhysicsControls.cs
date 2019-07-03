using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsControls : MonoBehaviour
{

    private Transform ThisTransform = null;
    public float Speed = 1f;
    public string HorzAxis = "Horizontal";
    public string VertAxis = "Vertical";

    private void Awake()

    {
        ThisTransform = GetComponent<Transform>();
    }

}
