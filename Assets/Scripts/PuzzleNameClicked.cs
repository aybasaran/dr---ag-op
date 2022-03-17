using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzleNameClicked : MonoBehaviour, IPointerClickHandler
{

    public AudioClip SpanishSpeech;
    public AudioClip EnglishSpeech;
    public AudioClip TurkishSpeech;

    public IDictionary<string, AudioClip> speechSounds;
    public AudioSource audioSource;
    public AudioClip clip;

    void Awake()
    {
        speechSounds = new Dictionary<string, AudioClip>(){
            {"tr-TR", TurkishSpeech},
            {"en-EN", EnglishSpeech},
            {"es-ES", SpanishSpeech}
        };
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.PlayOneShot(speechSounds[string.Format("{0}", PlayerPrefs.GetString("CurrentLang"))], 1f);
    }


}
