using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideinput : MonoBehaviour
{

    public GameObject InputCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
            InputCanvas.SetActive(false);

        }
    }

    public void hidewithbutton()
    {
        InputCanvas.SetActive(false);
    }
}
