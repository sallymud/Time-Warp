using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public BottomBarController bottonBar;

    void Start()
    {
        bottonBar.PlayScene(currentScene);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (bottonBar.IsCompleted())
            {
                bottonBar.PlayNextSentence();
            }
        }
    }
}
