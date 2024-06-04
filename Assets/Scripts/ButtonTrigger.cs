using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private Button button;

    private void OnTriggerEnter(Collider other) //when a collider makes contact with another collider
    {
        if (other.CompareTag("Interactive"))
        {
            button.onClick.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) //when a collider loses contact with another collider
    {
        if (other.CompareTag("Interactive"))
        {
            button.onClick.Invoke();
        }
    }
}
