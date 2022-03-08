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
    private int limitMin = 1;
    private int liminMax = 7;
    private Scene currentlyActiveScene;

    private int puzzleIndex;

    private void Start()
    {
        currentlyActiveScene = SceneManager.GetActiveScene();
        puzzleIndex = int.Parse(currentlyActiveScene.name[currentlyActiveScene.name.Length - 1].ToString());
    }

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

    public void NextPuzzle()
    {
        if (puzzleIndex < liminMax)
        {
            SceneManager.LoadScene("animals_" + (puzzleIndex + 1));
        }
    }
    public void PrevPuzzle()
    {
        if (puzzleIndex > limitMin)
        {
            SceneManager.LoadScene("animals_" + (puzzleIndex - 1));
        }
    }
}
