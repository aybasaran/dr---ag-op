using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class Language : MonoBehaviour
{

    public void English()
    {
        PlayerPrefs.SetString("CurrentLang", "en-EN");
    }
    public void Turkish()
    {
        PlayerPrefs.SetString("CurrentLang", "tr-TR");
    }
    public void Spain()
    {
        PlayerPrefs.SetString("CurrentLang", "es-ES");
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