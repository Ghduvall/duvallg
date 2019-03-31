using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
        Timer.CurrentTime = 10;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
