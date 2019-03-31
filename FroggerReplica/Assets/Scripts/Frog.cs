using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public static string CurrentPress;

	void Update () {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Pressed.CurrentKey = "right";
            rb.MovePosition(rb.position + Vector2.right);
        }
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Pressed.CurrentKey = "left";
            rb.MovePosition(rb.position + Vector2.left);
        }
		else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Pressed.CurrentKey = "up";
            rb.MovePosition(rb.position + Vector2.up);
        }
		else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PressedDown.CurrentDown = PressedDown.CurrentDown + 1;
            Pressed.CurrentKey = "down";
            rb.MovePosition(rb.position + Vector2.down);
        }
        else if (Lives.CurrentLife == 0)
        {
            Timer.CurrentTime = 10;
            Debug.Log("YOU LOST!");
            SceneManager.LoadScene(1);
        }


    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("Lost Life");
			Score.CurrentScore = Score.CurrentScore - 10;
            Lives.CurrentLife = Lives.CurrentLife - 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
        
	}
}
