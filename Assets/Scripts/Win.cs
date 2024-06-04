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
    [SerializeField] private Animator animationToPlay;

    [SerializeField] private float timer = 1;

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
            //Put it's Animator with animation here
            animationToPlay.SetBool("Play Animation", true);

            timer -= Time.deltaTime;
            if( timer < 0)
            {
                objectsToDeactivate.SetActive(false);
                objectsToActivate.SetActive(true);
            }
        }
    }
}
