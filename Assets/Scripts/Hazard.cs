using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2d collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(SceneManager)
        }
    }
}
