using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private float amp;
    [SerializeField] private SineWave sineWave;

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
        if(( sineWave.amplitude < 0.029 ) && (sineWave.amplitude > 0.02) )
        {
            objectsToDeactivate.SetActive(false);
            objectsToActivate.SetActive(true);
        }
    }
}
