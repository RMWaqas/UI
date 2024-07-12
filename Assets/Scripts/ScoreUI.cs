using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SliderData
{
    public string label;
    public int maxScore; 

    public Color sliderColor;

    public string pointsText;
} 
public class ScoreUI : MonoBehaviour
{
    [SerializeField] Option optionPrefab;
    [SerializeField] Transform optionContainer;
    [SerializeField] List<SliderData> data;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < data.Count; i++)
        {
            var optionClone = Instantiate(optionPrefab, optionContainer, false);
            optionClone.gameObject.SetActive(true);

            var optionData = data[i];
            optionClone.labelText.text = optionData.label;
            optionClone.backgroundImage.color = optionData.sliderColor;
            optionClone.slider.maxValue = optionData.maxScore;
            optionClone.ptsText.text = optionData.pointsText;
            //optionClone.slider.interactable = false; 
        }
    }
}
