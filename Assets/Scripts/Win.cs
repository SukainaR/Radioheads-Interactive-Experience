using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    
    [SerializeField] private SineWave sineWave;
    [SerializeField] private float ampMin;
    [SerializeField] private float ampMax;

    [SerializeField] private GameObject objectsToActivate;
    [SerializeField] private GameObject objectsToDeactivate;

    // Start is called before the first frame update
    void Start()
    {
        sineWave = GetComponent<SineWave>();
    }

    // Update is called once per frame
    void Update()
    {
        if(( sineWave.amplitude < ampMax ) && (sineWave.amplitude > ampMin) )
        {
            objectsToDeactivate.SetActive(false);
            objectsToActivate.SetActive(true);
        }
    }
}
