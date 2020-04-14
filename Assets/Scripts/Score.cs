using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int points = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        
        if(TimeCounter.time > 0)
        {
            if(TimeCounter.time == 10)
            {
                points -= 5;
            }
            else if(TimeCounter.time % 10 == 0)
            {
                points -= 5;
            }
        }
        score.text = "Helium: " + points;
    }

    public static void AddPoints(int pts)
    {
        points += pts;
    }
}
