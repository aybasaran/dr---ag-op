using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextConversion : MonoBehaviour
{
    [SerializeField] public string ENG;
    [SerializeField] public string SPA;
    [SerializeField] public string TUR;

    private Text convertedText;

    private void Awake()
    {
        setLanguage();
    }
    private void Update()
    {
        setLanguage();
    }
    public void setLanguage()
    {
        convertedText = GetComponent<Text>();
        switch (PlayerPrefs.GetString("CurrentLang"))
        {
            case "ENG":
                convertedText.text = ENG;
                break;
            case "TUR":
                convertedText.text = TUR;
                break;
            case "SPA":
                convertedText.text = SPA;
                break;
            case "ARA":
                break;
            default:
                convertedText.text = TUR;
                break;
        }
    }
}
