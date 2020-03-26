using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Clock : MonoBehaviour {
    //Analog elements
    public GameObject analogSecondHand;
    public GameObject analogMinuteHand;
    public GameObject analogHourHand;
    //Digital element
    public TextMesh digits;

    string oldSeconds;

    private float transformSecondsAndMinutes = -6;
    private float transformHours = -30;


    void Update() {

        string seconds = System.DateTime.UtcNow.ToString("ss");

        if (seconds != oldSeconds) {
            UpdateTimer();
        }
        oldSeconds = seconds;
    }

    void UpdateTimer() {
        //time variables
        int secondsInt = int.Parse(System.DateTime.Now.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.Now.ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.Now.ToString("hh"));

        //Analog Elements
        analogSecondHand.transform.rotation = Quaternion.Euler(0, 0, secondsInt * transformSecondsAndMinutes);
        analogMinuteHand.transform.rotation = Quaternion.Euler(0, 0, minutesInt * transformSecondsAndMinutes);
        analogHourHand.transform.rotation = Quaternion.Euler(0, 0, hoursInt * transformHours);

        //Digital Elements
        //digits.text = hoursVariable + " : " + minutesVariable + " : " + secondsVariable;
        digits.text = DateTime.Now.ToString("HH:mm:ss");



    }
}
