using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    /*[SerializeField] private Slider handSlider;*/
    [SerializeField] private float sliderValue;
    [SerializeField] private SineWave sineWave;


    // Start is called before the first frame update
    void Start()
    {
        sliderValue=GetComponent<float>();
        sineWave=GetComponent<SineWave>();
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = sineWave.amplitude;
    }
}
