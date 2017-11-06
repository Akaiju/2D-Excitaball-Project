using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    [SerializeField]
    private string leveltoLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(leveltoLoad);        
    }


}
