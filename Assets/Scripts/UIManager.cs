using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;
    GameObject[] finishObjects;
    GameObject[] playObject;
    GameObject winObject;
    
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");
        playObject = GameObject.FindGameObjectsWithTag("ShowOnPlay");
        winObject = GameObject.FindGameObjectWithTag("ShowOnWin");
        hidePaused();
        hideFinished();
        hideWon();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }

        if(Score.points <= 0 && (int)TimeCounter.seconds >= 10)
        {
            showFinished();
            Score.points = 0;
        }

        if(Score.points >= 500)
        {
            Time.timeScale = 0;
            showWon();
        }
    }
    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
        Score.points = 0;
    }

    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    public void showPaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
        foreach(GameObject t in playObject)
        {
            t.SetActive(false);
        }
        
    }

    public void hidePaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }

        foreach (GameObject t in playObject)
        {
            t.SetActive(true);
        }
    }

    public void showFinished()
    {
        Time.timeScale = 0;
        foreach(GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
        foreach (GameObject t in playObject)
        {
            t.SetActive(false);
        }
    }

    public void hideFinished()
    {
        foreach(GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }

    public void showWon()
    {
        winObject.SetActive(true);
    }

    public void hideWon()
    {
        winObject.SetActive(false);
    }

    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
        Score.points = 0;
    }
}
