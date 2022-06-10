using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LevelChanger changer;
    public DisableEnable disableenable;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDisable()
    {
        //Debug.Log("Disable");

        changer.FadeToLevel(1);
        disableenable.meshHidden(text);
    }

    private void OnEnable()
    {
        //Debug.Log("Enable");
        disableenable.meshShow(text);
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update is calling");
    }
}
