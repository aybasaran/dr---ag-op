using System;
using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IsComplete : MonoBehaviour
{
    [SerializeField]
    public GameObject puzzle;
    public GameObject[] pieces;
    // public Vector3[] positions;

    public GameObject puzzleNameText;
    private int counter = 0;
    private bool isComplete = false;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    private void Awake()
    {
        puzzleNameText.SetActive(false);
        puzzle.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        if (isComplete == false)
        {
            if (CheckPositions(this.pieces))
            {
                Debug.Log("Completed!");
                // Hayvanin adini goster && Sesini dinlet
                puzzleNameText.SetActive(true);
                audioSource.PlayOneShot(clip, volume);
                puzzle.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                // Debug.Log("Not Completed!");
            }
        }
    }

    private bool CheckPositions(GameObject[] pieces)
    {
        counter = 0;
        foreach (var piece in pieces)
        {
            //Side note Konumlari kendimiz girelim
            if (piece.transform.position == new Vector3(0f, 0f, 0f)) counter++;
        }
        if (counter == pieces.Length)
        {
            isComplete = true;
            return true;
        }
        return false;
    }
}
