using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TotalScore : MonoBehaviour
{
    [SerializeField] float firatSliderValue;
    [SerializeField] float secondSliderValue;
    //[SerializeField] float thirdSliderValue;
    [SerializeField] float finalScore;

    [SerializeField] Slider firstslider;
    [SerializeField] Slider secondSlider;
    //[SerializeField] Slider thirdSlider;

    TextMeshProUGUI finalScoreText; 

    bool hasStored = false;
    
    void Start() 
    {
        finalScoreText = GetComponent<TextMeshProUGUI>();
    }
    void Update() 
    {
        firatSliderValue = firstslider.value;
        secondSliderValue = secondSlider.value;

        finalScore = firatSliderValue + secondSliderValue;

        if (!hasStored)
        {
            hasStored = true;
            finalScoreText.text = finalScore.ToString() + "/200pts.";
        }

    }
}
