using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{

    public GameObject wheel;

    public MoveCube script;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = script.rb.velocity.z;

        //wheel.transform.Rotate(1f, 0, 0, Space.Self);
        if (script.rb.velocity.z > 0.5)
        {
            wheel.transform.Rotate(0.5f*velocity, 0, 0, Space.Self);
        }

    }
}
