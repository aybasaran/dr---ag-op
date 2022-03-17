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
        convertedText = GetComponent<Text>();
        setLanguage();
    }
    private void Update()
    {
        setLanguage();
    }
    public void setLanguage()
    {

        switch (PlayerPrefs.GetString("CurrentLang"))
        {
            case "en-EN":
                convertedText.text = ENG;
                break;
            case "tr-TR":
                convertedText.text = TUR;
                break;
            case "es-ES":
                convertedText.text = SPA;
                break;
            default:
                convertedText.text = TUR;
                break;
        }
    }
}
