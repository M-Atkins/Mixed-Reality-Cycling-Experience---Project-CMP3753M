using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRaycast : MonoBehaviour
{
    public Camera camera;

    void Start(){

    }
    void update(){
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;
            Debug.Log("HIT");
            
            // Do something with the object that was hit by the raycast.
        }
    }
}
