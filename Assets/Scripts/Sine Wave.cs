using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SineWave : MonoBehaviour
{
    public LineRenderer myLineRenderer;
    public int points;
    public float amplitude = 1.0f;
    public float frequency = 1;
    public Vector2 xLimits = new Vector2(0, 1);
    public float movementSpeed = 1;
    [Range(0, 2 * Mathf.PI)]
    public float radians;
    void Start()
    {
        myLineRenderer = GetComponent<LineRenderer>();
    }

    void Draw()
    {
        float xStart = xLimits.x;
        float Tau = 2 * Mathf.PI;
        float xFinish = xLimits.y;

        myLineRenderer.positionCount = points;
        for (int currentPoint = 0; currentPoint < points; currentPoint++)
        {
            float progress = (float)currentPoint / (points - 1);
            float x = Mathf.Lerp(xStart, xFinish, progress);
            float y = amplitude * Mathf.Sin((Tau * frequency * x) + (Time.timeSinceLevelLoad * movementSpeed));
            myLineRenderer.SetPosition(currentPoint, new Vector3(x, y, 0));
        }

        amplitude = Mathf.Clamp(amplitude, 0, 0.06f);
    }

    void Update()
    {
        Draw();
    }
}
