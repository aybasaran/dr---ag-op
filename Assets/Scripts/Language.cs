using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class Language : MonoBehaviour
{

    public void English()
    {
        PlayerPrefs.SetString("CurrentLang", "ENG");
        Debug.Log(PlayerPrefs.GetString("CurrentLang"));
    }
    public void Turkish()
    {
        PlayerPrefs.SetString("CurrentLang", "TUR");
        Debug.Log(PlayerPrefs.GetString("CurrentLang"));

    }
    public void Spain()
    {
        PlayerPrefs.SetString("CurrentLang", "SPA");
        Debug.Log(PlayerPrefs.GetString("CurrentLang"));
    }
    public void Arabic()
    {
        PlayerPrefs.SetString("CurrentLang", "ARA");
        Debug.Log(PlayerPrefs.GetString("CurrentLang"));
    }

    private void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate ()
        {
            // Debug.Log(b.gameObject.name);
            if (b.gameObject.name == "tr_lang")
            {
                Turkish();
            }
            else if (b.gameObject.name == "spa_lang")
            {
                Spain();
            }
            else if (b.gameObject.name == "en_lang")
            {
                English();
            }
        });
    }

}