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
                    PlayerPrefs.SetString("CurrentLang", "TUR");
                    break;
                case SystemLanguage.Spanish:
                    PlayerPrefs.SetString("CurrentLang", "SPA");
                    break;

                default:
                    PlayerPrefs.SetString("CurrentLang", "ENG");
                    Debug.Log("Varsayilan dil");
                    break;
            }
            PlayerPrefs.SetString("diffLevel", "normal");
        }
        PlayerPrefs.SetInt("firstBoot", 1);
    }
}
