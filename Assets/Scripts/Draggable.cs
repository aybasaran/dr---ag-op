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

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

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
        if (Mathf.Abs(transform.position.x - placer.transform.position.x) <= 0.7f && Mathf.Abs(transform.position.y - placer.transform.position.y) <= 0.7f)
        {
            if(!locked){
                audioSource.PlayOneShot(clip, volume);
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