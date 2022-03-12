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
        PlayerPrefs.SetString("diffLevel", gameObject.name);
    }

}
