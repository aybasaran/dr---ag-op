using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PuzzleImageClicked : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnMouseDown()
    {
        audioSource.PlayOneShot(audioClip, 0.75f);
    }

}
