﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caro : MonoBehaviour
{

    public Rigidbody CarRig;
    public int Speed;
    public int RotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
        CarRig = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update(){
        

        if (Input.GetKey(KeyCode.W)){

            CarRig.AddForce(transform.forward * Speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S)){

            CarRig.AddForce(transform.forward * -Speed * Time.deltaTime, ForceMode.Impulse);
        }


    if (Input.GetKey(KeyCode.A)){

        transform.Rotate(0, -RotSpeed,0);
    }

    if (Input.GetKey(KeyCode.D)){

        transform.Rotate(0, RotSpeed,0);
    }



    }
}
