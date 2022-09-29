using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio",0.5f);
        AudioListener.volume = slider.value;
        imMutated();
        
    }

    // Update is called once per frame
    public void changeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("volumenAudio",sliderValue);
        AudioListener.volume = slider.value;
        imMutated();
    }

    public void imMutated(){
        if (sliderValue == 0){
            image.enabled = true;
        }
        else{
            image.enabled = false;
        }

    }
}
