using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hider : MonoBehaviour
{
    public GameObject hider;

    // Start is called before the first frame update
    void Start()
    {
        hider = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("v"))
        {
            MeshRenderer mr = hider.GetComponent<MeshRenderer>();
            mr.enabled = false;
        }
    }
}
