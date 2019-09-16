using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorctr : MonoBehaviour
{

    public WheelJoint2D right;
    public WheelJoint2D left;

    public float speed = 1500;
    public float rotate = 1500;

    Rigidbody2D rg;


    JointMotor2D motor;


    // Start is called before the first frame update
    void Start()
    {
        motor.maxMotorTorque = 10000;
        rg = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        motor.motorSpeed = speed * Input.GetAxis("Vertical");

        right.motor = motor;
        left.motor = motor;
        rg.AddTorque(-rotate * Input.GetAxis("Horizontal") * Time.deltaTime);


    }
}
