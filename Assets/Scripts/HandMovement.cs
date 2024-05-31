using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandMovement : MonoBehaviour
{
    [SerializeField] private GameObject hand;
    [SerializeField] private Slider handSlider;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private float sliderMinX;
    [SerializeField] private float sliderMaxX;
    [SerializeField] private float customMaxValue = 1.0f;

    public void setInitialPosition()
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
        Debug.Log("Initial position set to: " + initialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (hand != null)
        {
            Vector3 handPosition = hand.transform.position;
            Debug.Log("Hand position: " + handPosition);

            float sliderValue = MapHandPositionToSliderValue(handPosition.x);
            Debug.Log("Calculated slider value: " + sliderValue);

            handSlider.value = sliderValue;
        }
    }

    private float MapHandPositionToSliderValue(float handXPosition)
    {
        // Ensure the hand's X position is within the defined range
        float clampedX = Mathf.Clamp(handXPosition, sliderMinX, sliderMaxX);
        Debug.Log("Clamped X position: " + clampedX);

        // Normalize the clamped X position to a value between 0 and 1
        float normalizedValue = (clampedX - sliderMinX) / (sliderMaxX - sliderMinX);
        Debug.Log("Normalized value: " + normalizedValue);

        // Map the normalized value to the range between 0 and customMaxValue
        float sliderValue = normalizedValue * customMaxValue;
        Debug.Log("Mapped slider value: " + sliderValue);

        return sliderValue;
    }
}
