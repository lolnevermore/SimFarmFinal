using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                break;

            case 2:
                if (score < 150)
                {
                    print("failure");
                }
                break;

            case 3:
                if (score < 300)
                {
                    print("failure");
                }
                break;

            case 4:
                if (score < 600)
                {
                    print("failure");
                }

                break;

            case 5:
                if (score < 1000)
                {
                    print("failure");
                }

                break;

            case 6:
                if(score < 1500)
                {
                    print("failure");
                }
                break;

            case 7:
                if(score < 2300)
                {
                    print("failure");
                }
                break;

            case 8:
                {
                    if (score >= 3000)
                    {
                        print("Success");
                    }
                    break;

                }

        }
    }
}
