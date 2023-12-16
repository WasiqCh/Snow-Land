using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueControl : MonoBehaviour
{   
    [SerializeField] float torque_amount = 15f;
    [SerializeField] float boost_speed=30f;
    [SerializeField] float base_speed=15f;
    bool canMove = true;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;

    // Start is called before the first frame update
    [Obsolete]
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
        Controller();
        Add_Boost();
        }
    }
    public void disableCont(){
        canMove = false;
    }

    void Add_Boost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed=boost_speed;
        }
        else
        {
            surfaceEffector2D.speed=base_speed;
        }
    }

    void Controller()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torque_amount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torque_amount);
        }
    }
}
