using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity;
using UnityEditor;


public class SceneController : MonoBehaviour
{

    public void goSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void listAnimalPuzzles()
    {
        PlayerPrefs.SetString("selectedPuzzleCategory", "animals");
        SceneManager.LoadScene("Animals");
    }
}
