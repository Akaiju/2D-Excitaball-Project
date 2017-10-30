using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //declare variables
    private AudioSource audioSource;
    private BoxCollider2D boxCollider2D;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        //intialize variables
        audioSource = GetComponent<AudioSource>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coin Touched");
        audioSource.Play();
        boxCollider2D.enabled = false;
        spriteRenderer.enabled = false;
        Destroy(gameObject, audioSource.clip.length + 0.2f);
    }

    private void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
