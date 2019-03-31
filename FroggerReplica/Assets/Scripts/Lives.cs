using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public static int CurrentLife = 3;
    public static string lives = "Lives Left: ";
    public Text livesText;


    void Start()
    {

    }

    void Update()
    {
        livesText.text = lives + CurrentLife.ToString();
    }
}
