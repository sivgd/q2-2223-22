using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeinseconds = 300;
    public TextMeshProUGUI timetext;
    public float timepassed = 0;
    public frogcounter frogcounter;
    public TextMeshProUGUI Highscore;
    private string Timep;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = PlayerPrefs.GetString("Highscore","0:00");

    }

    // Update is called once per frame
    void Update()
    {
        if(timepassed >= 0 && frogcounter.frogCount < 3)
        {
            timepassed += Time.deltaTime;
        }
        if(timeinseconds > 0)
        {
            timeinseconds -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("lose");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            Highscore.text = "0:00";
        }

        DisplayTime(timeinseconds);
        timePassed(timepassed);
    }

    void DisplayTime(float timetodisplay)
    {
        if(timetodisplay <0)
        {
            timetodisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timetodisplay / 60);
        float seconds = Mathf.FloorToInt(timetodisplay % 60);

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void timePassed(float timepassed)
    {
        if (timepassed < 0)
        {
            timepassed = 0;
        }

        float minutes = Mathf.FloorToInt(timepassed / 60);
        float seconds = Mathf.FloorToInt(timepassed % 60);
        Timep = string.Format("{0:00}:{1:00}", minutes, seconds);
        if(frogcounter.frogCount == 3)
        {
            if(timepassed <= PlayerPrefs.GetFloat("Highscoreinsec", 300)) 
            { 
                PlayerPrefs.SetFloat("Highscoreinsec", timepassed);
                PlayerPrefs.SetString("Highscore", Timep);
                Highscore.text = Timep;
            }

        }

    }

}
