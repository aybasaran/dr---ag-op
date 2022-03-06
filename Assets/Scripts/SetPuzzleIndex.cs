using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetPuzzleIndex : MonoBehaviour
{
    private Button btn;
    private string puzzle_index;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("animals" + "_" + this.gameObject.name);
    }
}
