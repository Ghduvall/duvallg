using UnityEngine;
using UnityEngine.UI;

public class CarsPassed : MonoBehaviour
{

    public static int CurrentCars = 0;
    public static string cars = "Cars Passed: ";
    public Text carText;


    void Start()
    {
        carText.text = cars + CurrentCars.ToString();
    }


}
