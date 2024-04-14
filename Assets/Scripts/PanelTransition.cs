using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransition : MonoBehaviour
{
    [SerializeField] private GameObject paneltoActivate;
    [SerializeField] private GameObject paneltoDeactivate;

    public void TransitiontoNextPanel()
    {
        paneltoActivate.SetActive(true);
        paneltoDeactivate.SetActive(false);
    }
}
