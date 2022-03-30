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
    public AudioClip SpanishSpeech;
    public AudioClip EnglishSpeech;
    public AudioClip TurkishSpeech;

    public IDictionary<string, AudioClip> speechSounds;


    [SerializeField]
    public GameObject puzzle;
    public GameObject[] pieces;
    // public Vector3[] positions;

    public GameObject puzzleName;
    private string puzzleTxt;

    private int counter = 0;
    private bool isComplete = false;

    public AudioSource audioSource;
    public AudioClip clip;

    private void Awake()
    {
        speechSounds = new Dictionary<string, AudioClip>(){
            {"tr-TR", TurkishSpeech},
            {"en-EN", EnglishSpeech},
            {"es-ES", SpanishSpeech}
        };


        puzzleTxt = puzzleName.GetComponent<Text>().text;
        puzzleName.SetActive(false);
        puzzle.SetActive(false);
    }

    private void Update()
    {
        if (isComplete == false)
        {
            if (CheckPositions(this.pieces))
            {
                puzzleName.SetActive(true);
                puzzle.SetActive(true);
                PlayAnimalSound();

                Invoke("PlaySpeechSound", clip.length);
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

    private void PlayAnimalSound()
    {
        audioSource.PlayOneShot(clip, 1f);
    }
    private void PlaySpeechSound()
    {
        audioSource.PlayOneShot(speechSounds[string.Format("{0}", PlayerPrefs.GetString("CurrentLang"))], 2f);
    }
}
