using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public GameObject wavestationary;
    public GameObject wavematching;
    public float amplitudeinput;
    public float inputMultiplier;
    public float debug;
    [SerializeField] private Animator myanimator;
    

    void Start()
    {
        
    }

    void Update()
    {
        amplitudeinput = Input.GetAxisRaw("Horizontal") * inputMultiplier;

        wavematching.GetComponent<SineWave>().amplitude += amplitudeinput;

        if (Input.GetButtonDown("Submit") && Mathf.Abs(wavematching.GetComponent<SineWave>().amplitude - wavestationary.GetComponent<SineWave>().amplitude) < 0.015f)
        {
            myanimator.SetBool("StartAnimation",true);
            print("test");
            
        }
        debug = Mathf.Abs(wavematching.GetComponent<SineWave>().amplitude - wavestationary.GetComponent<SineWave>().amplitude);
    }
}
