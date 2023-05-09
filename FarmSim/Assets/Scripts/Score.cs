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
    public int goalScore;
    public TMP_Text Pscore;
    public TMP_Text Pgoal;
    public TMP_Text PscoreShadow;
    public TMP_Text PgoalShadow;
    public GameObject Success;
    public GameObject Failure;
    public GameObject Win;


    // Start is called before the first frame update
    void Start()
    {
        score = startingScore;
        garf = GameObject.Find("Timer");
        timer = garf.GetComponent<Timer>();
        Success.SetActive(false);
        Failure.SetActive(false);
        Win.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        //print(score);
        Pgoal.GetComponent<TMP_Text>().text = "Goal: " + goalScore.ToString();
        Pscore.GetComponent<TMP_Text>().text = "Score: " + score.ToString();
        PgoalShadow.GetComponent<TMP_Text>().text = "Goal: " + goalScore.ToString();
        PscoreShadow.GetComponent<TMP_Text>().text = "Score: " + score.ToString();



        ScoreCheckAmounts();

        /*if(timer.currentTime == 0)
        {
            score = 0;
        }*/
    }
    public void SubtractPoints(int amount)
    {
        score -= amount;

        // Ensure the main character never has negative points
        if (score < 0)
        {
            score = 0;
        }
    }


    void ScoreCheckAmounts()
    {
        switch (timer.day) 
        {
            case 1:
                goalScore = 50;
                if (score < 50)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);

                }
                else if (score >= 50)
                {
                    print("success");
                    //Time.timeScale = 0f;
                    //Success.SetActive(true);
                    goalScore = 100;
                }
                break;
                


            case 2:
                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 200;
                }
                break;

            case 3:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 350;
                }
                break;

            case 4:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 550;
                }

                break;

            case 5:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 700;
                }

                break;

            case 6:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 800;
                }
                break;

            case 7:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                    print("success");
                //    Time.timeScale = 0f;
                //    Success.SetActive(true);
                    goalScore = 1000;
                }
                break;

            case 8:

                if (score < goalScore)
                {
                    print("failure");
                    Time.timeScale = 0f;
                    Failure.SetActive(true);
                }
                else if (score >= goalScore)
                {
                //    print("success");
                //    Time.timeScale = 0f;
                    Win.SetActive(true);
                }
                break;

        }
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        Success.SetActive(false);
    }
}
