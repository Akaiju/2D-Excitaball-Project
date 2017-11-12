using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoLevelCoin : MonoBehaviour
{
    //declare variables
    [SerializeField]
    private string leveltoLoad;
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

        if(collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            boxCollider2D.enabled = false;
            spriteRenderer.enabled = false;
    
            Destroy(gameObject, audioSource.clip.length + 0.2f);

            SceneManager.LoadScene(leveltoLoad);

        }
        
    }
}
