using UnityEngine;
using UnityEngine.UI;

public class PressedDown : MonoBehaviour
{

    public static int CurrentDown = 0;
    public static string down = "Down Key Pressed: ";
    public Text downText;


    void Start()
    {
        downText.text = down + CurrentDown.ToString();
    }


}
