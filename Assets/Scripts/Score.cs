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
        InvokeRepeating("DeductPoints", 10f, 10f);
    }

    void Update()
    {
        score.text = "Helium: " + points;
    }

    public static void AddPoints(int pts)
    {
        points += pts;
    }

    public void DeductPoints()
    {
        if ((int)TimeCounter.seconds == 10)
        {
            points -= 5;
        }
        else if ((int)TimeCounter.seconds % 10 == 0)
        {
            points -= 5;
        }
    }
}
