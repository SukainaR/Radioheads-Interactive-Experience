using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    [SerializeField] private List<GameObject> levelsToDeactivate = new List<GameObject>();
    [SerializeField] private List<GameObject> levelsToActivate = new List<GameObject>();

    public void TransitionToNextLevel()
    {
        foreach (GameObject obj in levelsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
                
        }

        foreach (GameObject obj in levelsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            } 
                
        }
    }
}
