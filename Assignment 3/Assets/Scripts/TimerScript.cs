using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public static int timerValue;
    Text timer;

	// Use this for initialization
	void Start () {
		timer = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        timerValue = (int)Time.time;



        timer.text = "Time: " + timerValue;

    }
}
