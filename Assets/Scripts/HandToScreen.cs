using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandToScreen : MonoBehaviour
{
    [SerializeField] private RectTransform canvasRectTransform;

    [SerializeField] private GameObject hand;
    [SerializeField] private GameObject imageChild;

    private float canvasXMin;
    private float canvasXMax;
    private float canvasYMin;
    private float canvasYMax;

    
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        CalculateCanvasBounds();
        offset = imageChild.transform.localPosition - hand.transform.localPosition;
        ClampImageChildPosition();
    }

    // Update is called once per frame
    void Update()
    {
        ClampImageChildPosition();
    }

    private void CalculateCanvasBounds()
    {
        Vector3[] canvasCorners = new Vector3[4];
        canvasRectTransform.GetWorldCorners(canvasCorners);

        
        canvasXMin = canvasCorners[0].x;
        canvasXMax = canvasCorners[2].x;
        canvasYMin = canvasCorners[0].y;
        canvasYMax = canvasCorners[2].y;
    }

    private void ClampImageChildPosition()
    {
        Vector3 handPosition = hand.transform.localPosition;

        // Calculate the target position of the image child with the offset
        Vector3 targetPosition = handPosition + offset;

        // Clamp the target position within the canvas bounds
        targetPosition.x = Mathf.Clamp(targetPosition.x, canvasXMin, canvasXMax);
        targetPosition.y = Mathf.Clamp(targetPosition.y, canvasYMin, canvasYMax);

        // Apply the clamped position to the image child, maintaining the offset
        imageChild.transform.localPosition = targetPosition - handPosition + offset;
    }
}
