using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField]
    GameObject QuitPanel;


    public void ThirdLevelQuit()
    {
        QuitPanel.SetActive(true);

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ThirdLevelQuit();
    }

}
