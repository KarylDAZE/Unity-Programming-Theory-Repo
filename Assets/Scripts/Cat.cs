using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private float forwardForce = 0.5f;
    public override void Jump()
    {
        base.Jump();
        rb.AddForce(Vector3.forward * forwardForce, ForceMode.Impulse);
    }
    void Awake()
    {
        jumpImpulse = 5;
    }
}
