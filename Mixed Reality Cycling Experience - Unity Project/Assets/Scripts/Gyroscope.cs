using UnityEngine;

public class Gyroscope : MonoBehaviour
{
    private Quaternion offset;

    private void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
        offset = transform.rotation * Quaternion.Inverse(GyroToUnity(Input.gyro.attitude));
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.supportsGyroscope)
            GyroModifyCamera();

    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        //difference of x y z??

        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }

    void GyroModifyCamera()
    {
        //Apply offset
        transform.rotation = offset * GyroToUnity(Input.gyro.attitude);
    }
}