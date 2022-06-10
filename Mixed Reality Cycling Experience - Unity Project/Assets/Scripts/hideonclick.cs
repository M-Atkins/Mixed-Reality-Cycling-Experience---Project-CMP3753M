using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideonclick : MonoBehaviour
{

    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disable()
    {
        button.SetActive(false);
    }
}
