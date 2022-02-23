using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
public class HelperFuncs : MonoBehaviour
{
    public static List<string> loadPuzzlesRelatedToActiveCategory()
    {
        string activeCategory = PlayerPrefs.GetString("activeCategory") + '_';
        List<string> puzzle_names = new List<string>();
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        for (int i = 0; i < sceneCount; i++)
        {
            if (System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(i)).Contains(activeCategory))
                puzzle_names.Add(System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(i)));
        }
        return puzzle_names;
    }
}
