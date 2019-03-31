using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public static float CurrentTime = 10f;
    public static string timer = "Time: ";
    public Text timerText;


    void Start()
    {

    }

    void Update()
    {
        timerText.text = timer + CurrentTime.ToString("F0");

        CurrentTime -= Time.deltaTime;
        if (CurrentTime < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
