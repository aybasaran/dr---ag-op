using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Draggable : MonoBehaviour
{
    public const string LAYER_NAME = "PPiece";

    private const string MOVING_LAYER_NAME = "PMoving";
    public int sortingOrder = 0;
    private SpriteRenderer sprite;
    public GameObject placer;
    private bool locked = false;
    private Vector3 initialmousePosition;
    private Vector3 initialPosition;
    private int heldPuzzleIndex;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    private float difficultyMultiplier;

    public GameObject confetti;
    private ParticleSystem confettiParticles;
    public GameObject confettiPosition;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        confettiParticles = confetti.GetComponent<ParticleSystem>();
        confettiParticles.Stop();

        switch (PlayerPrefs.GetString("diffLevel"))
        {
            case "easy":
                difficultyMultiplier = 1.1f;
                break;
            case "hard":
                difficultyMultiplier = 0.4f;
                break;

            default:
                difficultyMultiplier = 0.75f;
                break;
        }
    }
    private void Start()
    {
        if (sprite)
        {
            sprite.sortingOrder = sortingOrder;
            sprite.sortingLayerName = LAYER_NAME;
        }

    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            initialPosition = transform.position;
            initialmousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseDrag()
    {
        // Fare ile surukleme halindeyken sorting leyerini diger puzzlelarin ustunde olacak sekilde ayarla
        // this.setSortingLayer("MovingPuzzle")
        sprite.sortingLayerName = MOVING_LAYER_NAME;
        if (!locked)
        {
            transform.position = initialPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - initialmousePosition);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - placer.transform.position.x) <= difficultyMultiplier && Mathf.Abs(transform.position.y - placer.transform.position.y) <= difficultyMultiplier)
        {
            if (!locked)
            {
                audioSource.PlayOneShot(clip, volume);
                confetti.transform.position = confettiPosition.transform.position;
                confettiParticles.Play();
            }
            transform.position = placer.transform.position;
            locked = true;
            // Debug.Log("Puzzle Placed!");
        }
        else
        {
            transform.position = initialPosition;
            locked = false;
        }
        // Puzzlein sorting layerini eski haline yani puzzle olarak degistir
        // this.setSortingLayer("Puzzle")
        sprite.sortingLayerName = LAYER_NAME;
    }
}