using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandButton : MonoBehaviour
{
    [SerializeField] private GameObject hand;
    [SerializeField] private Button[] buttons;

    [SerializeField] private int currentActive;
    

    public RectTransform canvasPosition; // The position on the Canvas to track against
    public float activationDistance = 50.0f; // Distance in screen units at which the button is activated

    void Update()
    {
        // Convert the world position of the target object to screen position
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(hand.transform.position);

        // Get the screen position of the canvas position
        Vector2 canvasScreenPosition = RectTransformUtility.WorldToScreenPoint(null, canvasPosition.position);

        // Calculate the distance between the game object's screen position and the canvas position
        float distance = Vector2.Distance(screenPosition, canvasScreenPosition);

        // Check if the distance is within the activation range
        if (distance <= activationDistance)
        {
            
            if (buttons[currentActive].gameObject.activeSelf)
            {
                // Simulate button click
                buttons[currentActive].onClick.Invoke();
            }
            
        }
    }
}
