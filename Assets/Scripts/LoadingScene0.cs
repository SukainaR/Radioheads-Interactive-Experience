using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene0 : MonoBehaviour
{
    [SerializeField] private GameObject[] objectToActivate;
    [SerializeField] private GameObject[] objectToDeactivate;
    [SerializeField] public float activationDelay = 2.0f;
    [SerializeField] public float deactivationDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ManageElements());
    }

    IEnumerator ManageElements()
    {
        // Deactivate elements after deactivationDelay seconds
        yield return new WaitForSeconds(deactivationDelay);
        foreach (GameObject element in objectToDeactivate)
        {
            element.SetActive(false);
        }

        // Wait for activationDelay seconds before activating new elements
        yield return new WaitForSeconds(activationDelay);
        foreach (GameObject element in objectToActivate)
        {
            element.SetActive(true);
        }
    }
}
