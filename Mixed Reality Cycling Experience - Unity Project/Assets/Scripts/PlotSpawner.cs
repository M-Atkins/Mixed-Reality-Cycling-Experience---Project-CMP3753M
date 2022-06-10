using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 1;
    //private float initStartZ;
    private float plotSize = 350;
    private float xPosLeft = -88;
    private float xPosRight = 90;
    private float lastZPos = 0;
    

    public List<GameObject> plots;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlot()
    {
        //Debug.Log("SPAWNED");
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        GameObject clone1 = Instantiate(plotLeft, new Vector3(xPosLeft, 0.35f, zPos), plotLeft.transform.rotation);
        //Instantiate(plotLeft, new Vector3(xPosLeft*2.8f, 0.35f, zPos), plotLeft.transform.rotation);

        GameObject clone2 = Instantiate(plotRight, new Vector3(xPosRight, 0.35f, zPos), new Quaternion(0, 0, 0, 0));
        //Instantiate(plotRight, new Vector3(xPosRight*2.8f, 0.35f, zPos), new Quaternion(0, 0, 0, 0));

        //if (Vector3.Distance(transform.position, plotLeft.transform.position) > 20)
            //Destroy(plotLeft);

        //if (clone1.transform.position.z > moveCube.rb.transform.position.z+50)
            //Destroy(clone1);
        lastZPos += plotSize;
    }
}
