using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public static int endScore = Score.CurrentScore;
    public static string score = "End Score: ";
    public Text scoreText;


    void Start()
    {
        scoreText.text = score + endScore.ToString();
    }

   
}
