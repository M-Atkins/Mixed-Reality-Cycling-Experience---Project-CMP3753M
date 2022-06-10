using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoble : MonoBehaviour
{

    public BleTest BleTest;

    // Start is called before the first frame update
    void Start()
    {
        BleTest.StartConHandler();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
