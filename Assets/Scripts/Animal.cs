using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
public class Animal : MonoBehaviour
{
    public string animalName
    {
        get { return animalName; }
        set
        {
            if (value.Length > 10)
                Debug.LogError("name too long!");
            else animalName = value;
        }
    }
    protected float jumpImpulse;
    protected Rigidbody rb;
    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * jumpImpulse, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

}
