using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransition : MonoBehaviour
{
    [SerializeField] private GameObject objectToDeactivate;
    [SerializeField] private GameObject objectToActivate;

    public void TransitionToNextPanel()
    {
        objectToDeactivate.SetActive(false);
        objectToActivate.SetActive(true);
    }
}
