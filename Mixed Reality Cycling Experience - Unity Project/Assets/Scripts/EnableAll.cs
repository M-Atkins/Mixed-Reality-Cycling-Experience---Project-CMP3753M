using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAll : MonoBehaviour
{

    public GameObject Play;
    public GameObject Info;
    public GameObject reasoning;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void disabled()
    {
        meshShow(Play);
        meshShow(Info);
        meshShow(reasoning);
    }



    public void meshHidden(GameObject obj)
    {
        MeshRenderer render = obj.gameObject.GetComponentInChildren<MeshRenderer>();
        render.enabled = false;
    }
    public void meshShow(GameObject obj)
    {
        MeshRenderer render = obj.gameObject.GetComponentInChildren<MeshRenderer>();
        render.enabled = false;
    }
}
