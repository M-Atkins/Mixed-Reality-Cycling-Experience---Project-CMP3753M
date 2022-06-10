using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTravelled : MonoBehaviour
{
    public GameObject player;
    public float totalDistance = 0;
    public bool record = true;
    private Vector3 previousLoc;

    private void Start()
    {
        totalDistance = totalDistance - player.transform.position.z;
    }
    void FixedUpdate()
    {
        if (record)
            RecordDistance();
    }
    void RecordDistance()
    {
        totalDistance += Vector3.Distance(transform.position, previousLoc);
        previousLoc = transform.position;
    }
    void ToggleRecord() => record = !record;
}
