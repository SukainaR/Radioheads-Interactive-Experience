using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedScreen : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToActivate;
    [SerializeField] private GameObject[] objectsToDeactivate;

    [SerializeField] private float timer = 0f;
    [SerializeField] private float waitTime = 3.0f;

    [SerializeField] private int currentActive;

    public bool startDesactivating;

    public void StartDeactivating()
    {
        startDesactivating = true;
    }

    /*public void TransitionToNextPanel()
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startDesactivating)
        {
            if (currentActive < objectsToActivate.Length -1)
            {
                timer += Time.deltaTime;
            }

            if (timer > waitTime)
            {
                timer = 0f;

                objectsToActivate[currentActive].SetActive(false);

                if (currentActive < objectsToActivate.Length -1)
                {
                    objectsToActivate[currentActive + 1].SetActive(true);
                }

                currentActive++;

                //objectsToDeactivate[0].SetActive(false);
                //objectsToActivate[1].SetActive(true);

                /*foreach (GameObject obj in objectsToDeactivate)
                {
                    obj.SetActive(false);
                }

                foreach (GameObject obj in objectsToActivate)
                {
                    obj.SetActive(true);
                }*/
            }
        }
    }
}
