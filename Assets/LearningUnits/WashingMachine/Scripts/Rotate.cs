using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Rigidbody rigidbody2;
    //[SerializeField] RigidBody rigidbody2;
    //[SerializeField]public float torque;
    [SerializeField] Vector3 moveDirection;
    // Had to make the red cube not kinematic
    // Start is called before the first frame update
    void Start()
    {
        //moveDirection = new Vector3(-2, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();
        //float turn = Input.GetAxis("Horizontal");
        //rigidbody.AddTorque(transform.up * torque * turn);
        
    }

    // Update is called once per frame
    void Update()
    {
        // Don't change this!
        rigidbody.AddTorque(moveDirection, ForceMode.Force);
        rigidbody2.angularVelocity = rigidbody.angularVelocity;
        //rigidbody2.AddTorque(moveDirection, ForceMode.Force);
    }
}
