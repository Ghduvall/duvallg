using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Button introContinueBtn;
    public Button optionsBtn;
    public Button saveOptionsBtn;
    public Button startBtn;
    public Button restartBtn;

    
    // Start is called before the first frame update
    void Start()
    {
        introContinueBtn.onClick.AddListener(scenePreScore);

        optionsBtn.onClick.AddListener(sceneOptions);

        saveOptionsBtn.onClick.AddListener(sceneIntro);

        startBtn.onClick.AddListener(sceneMain);

        restartBtn.onClick.AddListener(sceneIntro);


    }

    public void sceneIntro()
    {
        GameScore.playerScore = 0;
        SceneManager.LoadScene(0);
    }
    public void sceneOptions()
    {
        SceneManager.LoadScene(1);
    }
    public void scenePreScore()
    {
        SceneManager.LoadScene(2);
    }
    public void sceneMain()
    {
        SceneManager.LoadScene(3);
    }
    
}
