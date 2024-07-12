using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option : MonoBehaviour
{
    //SliderData value;
    public Image backgroundImage;
    public TextMeshProUGUI labelText;
    public Slider slider;

    public TextMeshProUGUI ptsText;

    public void GetSliderValue(Slider sliderValue)
    {
        ptsText.text = sliderValue.value.ToString();
    }
}
