using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
    public ChangeScene changeScene;

    public static int playerScore = 0;
    public Text scoreText;
    public static string score = "Score: ";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + playerScore.ToString();
        
        if (playerScore == 10)
        {
            SceneManager.LoadScene(4);
        }
    }
}
