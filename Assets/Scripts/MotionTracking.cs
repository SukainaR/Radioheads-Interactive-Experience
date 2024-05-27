using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionTracking : MonoBehaviour
{
    public ReceiveDataFromTracking udpReceive;
    public GameObject[] bodyPoints;

    public string[] points;

    // Update is called once per frame
    void Update()
    {
        string data = udpReceive.data;
        data = data.Remove(0, 2);
        data = data.Remove(data.Length - 2, 2);

        points = data.Split(',');

        for (int i = 0; i < 32; i++)
        {
            float x = float.Parse(points[i * 3]) / 100;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            //float z = float.Parse(points[i * 3 + 2]) / 100;

            float z = 0;

            bodyPoints[i].transform.localPosition = new Vector3(x, y, 0);
        }

    }
}
