using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;
    public static string score = "Score: ";
	public Text scoreText;


	void Start ()
	{
        
        scoreText.text = score + CurrentScore.ToString();
	}

    void Update()
    {
        timerPoints();
    }

    void timerPoints()
    {
        if (Timer.CurrentTime <= 5)
        {
            CurrentScore = CurrentScore - 1;
        }
    }
}
