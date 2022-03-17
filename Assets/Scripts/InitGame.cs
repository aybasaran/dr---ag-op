using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class InitGame : MonoBehaviour
{

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        // Set Default Values
        if (!PlayerPrefs.HasKey("firstBoot"))
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Turkish:
                    PlayerPrefs.SetString("CurrentLang", "tr-TR");
                    break;
                case SystemLanguage.Spanish:
                    PlayerPrefs.SetString("CurrentLang", "es-ES");
                    break;

                default:
                    PlayerPrefs.SetString("CurrentLang", "en-EN");
                    break;
            }
            PlayerPrefs.SetString("diffLevel", "normal");
        }
        PlayerPrefs.SetInt("firstBoot", 1);
    }
}
