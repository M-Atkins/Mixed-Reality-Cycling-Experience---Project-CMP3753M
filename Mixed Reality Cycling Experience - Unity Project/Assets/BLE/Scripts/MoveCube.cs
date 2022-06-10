using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    //private BleTest script;
    public BleTest script;
    //public float movementSpeed = 10f;



    float MaxSpeed = 50f;
    public float movementSpeed = 0;
    public Rigidbody rb;
    public bool isTurning = false;
    public bool hasMoved = false;


    List<float> Forces = new List<float>();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementSpeed = 0;
    }



    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.z > 1)
        {
            Debug.Log("HASMOVED TRUE");
            hasMoved = true;
        }


        Debug.Log(rb.velocity);
        float spd = script.remoteAngle;
        if (movementSpeed == script.remoteAngle || movementSpeed == script.remoteAngle +1 || movementSpeed == script.remoteAngle - 1)
        {
            isTurning = false;
            Debug.Log("MATCH");


        }
        else
        {
            isTurning = true;
            Debug.Log("NO MATCH");
            movementSpeed = script.remoteAngle;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, +50));
            //they dont match, so the bicycle is moving
        }



        if (rb.velocity.z > 50)
        {
            Debug.Log("TOOFAST");
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -50));
        }




    }
}

/*
          //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, +10));
        
        //start as 0

        //if != , then moving is true

        //if == , then is false.
        
        //if value has not changed, the reduce speed.
        

        /*
        if (movementSpeed < 50)
        {
            //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, movementSpeed));
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 20));
            //rb.velocity = new Vector3(0, 0, 10);

        }
*/