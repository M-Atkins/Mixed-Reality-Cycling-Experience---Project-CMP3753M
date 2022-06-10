using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnable : MonoBehaviour
{

    public GameObject Play;
    public GameObject Playtext;

    public GameObject Instructions;
    public GameObject Instructionstext;

    public GameObject reasoning;
    public GameObject reasoningtext;

    public GameObject back;
    public GameObject backtext;



    public void Disabling()
    {
        meshHidden(Play);
        meshHidden(Playtext);

        meshHidden(Instructions);
        meshHidden(Instructionstext);

        meshHidden(reasoning);
        meshHidden(reasoningtext);

        meshShow(back);
        meshShow(backtext);

        back.SetActive(true);
    }

    public void Enabling()
    {

        meshShow(Play);
        meshShow(Playtext);

        meshShow(Instructions);
        meshShow(Instructionstext);

        Instructions.SetActive(true);
        meshShow(Instructionstext);

        meshShow(reasoning);
        reasoning.SetActive(true);
        meshShow(reasoningtext);

        meshHidden(back);
        meshHidden(backtext);
    }


    public void meshHidden(GameObject obj)
    {
        MeshRenderer render = obj.gameObject.GetComponentInChildren<MeshRenderer>();
        render.enabled = false;
    }
    public void meshShow(GameObject obj)
    {
        MeshRenderer render = obj.gameObject.GetComponentInChildren<MeshRenderer>();
        render.enabled = true;
    }
}
