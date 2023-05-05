using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    int startingScore = 0;
    int daynum;
    GameObject garf;
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        score = startingScore;
        garf = GameObject.Find("Timer");
        timer = garf.GetComponent<Timer>();

       
    }

    // Update is called once per frame
    void Update()
    {
        print(score);
        

        ScoreCheckAmounts();

        /*if(timer.currentTime == 0)
        {
            score = 0;
        }*/
    }


    void ScoreCheckAmounts()
    {
        switch (timer.day) 
        {
            case 1:
                if (score < 50)
                {
                    print("failure");
                }
                else if (score >= 50)
                {
                    print("success");
                    Time.timeScale = 0f;
                    
                }
                break;

            case 2:
                if (score < 100)
                {
                    print("failure");
                }
                else if (score >= 100)
                {
                    print("success");
                    Time.timeScale = 0f;
                }
                break;

            case 3:
                if (score < 200)
                {
                    print("failure");
                }
                else if (score >= 200)
                {
                    print("success");
                    Time.timeScale = 0f;
                }
                break;

            case 4:
                if (score < 350)
                {
                    print("failure");
                }
                else if (score >= 350)
                {
                    print("success");
                    Time.timeScale = 0f;
                }

                break;

            case 5:
                if (score < 550)
                {
                    print("failure");
                }
                else if (score >= 550)
                {
                    print("success");
                    Time.timeScale = 0f;
                }

                break;

            case 6:
                if(score < 700)
                {
                    print("failure");
                }
                else if (score >= 700)
                {
                    print("success");
                    Time.timeScale = 0f;
                }
                break;

            case 7:
                if(score < 800)
                {
                    print("failure");
                }
                else if (score >= 800)
                {
                    print("success");
                    Time.timeScale = 0f;
                }
                break;

            case 8:
                {
                if (score < 1000)
                {
                    print("failure");
                }
                else if (score >= 1000)
                {
                    print("success");
                    Time.timeScale = 0f;
                }
                break;
                }

        }
    }
}
