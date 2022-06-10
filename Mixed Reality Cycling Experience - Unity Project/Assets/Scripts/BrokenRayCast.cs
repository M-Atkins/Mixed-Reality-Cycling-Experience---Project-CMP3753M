using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRayCast : MonoBehaviour
{
    RaycastHit hit;
    bool isCounting = false;
    float countdown;
    public float time = 3;
    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            if (hit.transform.CompareTag("Option")) isCounting = true;
        }
        else
        {
            isCounting = false;
            //This happens every frame the user isn't looking at an "option" so this could be optimized. But not a big problem.
            countdown = time;
        }

        if (countdown <= 0)
        {
            //Select option
            //hit.transform.GetComponent<>().DoSomething();
            Debug.Log("SELECTED");
        }
        if (isCounting) countdown -= Time.deltaTime;
    }
}
