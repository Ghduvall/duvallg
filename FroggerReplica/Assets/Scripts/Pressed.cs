using UnityEngine;
using UnityEngine.UI;

public class Pressed : MonoBehaviour
{

    public static string CurrentKey = "";
    public static string pressed = "Pressed: ";
    public Text pressedText;


    void Start()
    {
        
    }

    void Update()
    {
        pressedText.text = pressed + CurrentKey.ToString();
    }
}
