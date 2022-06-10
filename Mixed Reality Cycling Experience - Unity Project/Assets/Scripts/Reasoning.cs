using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reasoning : MonoBehaviour
{
    public DisableEnable disableenable;

    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDisable()
    {
        disableenable.Disabling();
        disableenable.meshHidden(text);
        //also show text
    }
    private void OnEnable()
    {
        disableenable.Enabling();
        disableenable.meshShow(text);

        //also show text
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
