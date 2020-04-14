using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text timeText;
    public static float seconds;
    public static int time;
    private int minutes;

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    public void UpdateTime()
    {
        seconds += Time.deltaTime;
        time += (int)Time.deltaTime;
        timeText.text = minutes.ToString("00") + ":" + ((int)seconds).ToString("00");
        if(seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }
    }
}
