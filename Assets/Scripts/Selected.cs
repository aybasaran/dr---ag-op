using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    [SerializeField] private GameObject tick;
    private Button btn;
    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(changeDifficultyLevel);
        tick.SetActive(false);
        // Debug.Log(gameObject.name);
        if (PlayerPrefs.GetString("diffLevel") == gameObject.name)
        {
            tick.SetActive(true);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("diffLevel") == gameObject.name)
        {
            tick.SetActive(true);
        }
        else
        {
            tick.SetActive(false);
        }
    }

    private void changeDifficultyLevel()
    {
        Debug.LogFormat("Zorluk seviyesi degisti! {0}", gameObject.name);
        PlayerPrefs.SetString("diffLevel", gameObject.name);
    }

}
