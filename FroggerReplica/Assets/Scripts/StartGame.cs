using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button restartButton;

    void Start()
    {
        restartButton.onClick.AddListener(restartGame);    
    }



    void restartGame()
    {
        Score.CurrentScore = 0;
        PressedDown.CurrentDown = 0;
        Timer.CurrentTime = 10;
        Lives.CurrentLife = 3;
        SceneManager.LoadScene(0);
    }
}
