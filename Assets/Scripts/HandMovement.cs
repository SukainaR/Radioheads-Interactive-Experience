using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class HandMovement : MonoBehaviour
{
    [SerializeField] private GameObject hand;
    [SerializeField] private Slider handSlider;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private float sliderMinX; 
    [SerializeField] private float sliderMaxX;


    public void setInitialPosition ()
    {
        if (hand != null)
        {
            initialPosition = hand.transform.position;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        setInitialPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (hand != null)
        {
            Vector3 handPosition = hand.transform.position;

            float sliderValue = MapHandPositionToSliderValue(handPosition.x);

            handSlider.value = sliderValue;
        }
    }

    private float MapHandPositionToSliderValue(float handXPosition)
    {
        // Ensure the hand's X position is within the defined range
        float clampedX = Mathf.Clamp(handXPosition, sliderMinX, sliderMaxX);

        // Normalize the clamped X position to a value between 0 and 1
        float normalizedValue = (clampedX - sliderMinX) / (sliderMaxX - sliderMinX);

        // Reverse the direction of the slider value
        float sliderValue = Mathf.Lerp(handSlider.maxValue, handSlider.minValue, normalizedValue);

        return sliderValue;
    }
}
