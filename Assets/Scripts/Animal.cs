using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
public class Animal : MonoBehaviour
{
    private string _animalName = "animal";
    public string AnimalName
    {
        get { return _animalName; }
        set
        {
            if (value.Length > 10)
                Debug.LogError("name too long!");
            else _animalName = value;
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
        AnimalName = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
        if (Input.GetKeyDown(KeyCode.L))
        {
            AnimalName = "LengthLongerThan10";
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            AnimalName = gameObject.name;
            Debug.Log(AnimalName);
        }
    }

}
