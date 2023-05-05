using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] Image uiFill;
    [SerializeField] TextMeshProUGUI uiText;
    [SerializeField] GameObject blight;
    public int day = 0;
    [SerializeField] float dayLength = 60;
    //int dayLengthInc = 60;
    [SerializeField] public float currentTime;
    int yaga;


    void Update()
    {

        currentTime += Time.deltaTime;
        DayTracker();

    }


    void DayTracker()
    {
        uiFill.fillAmount = (currentTime / dayLength);
        if (currentTime >= dayLength)
        {
            day++;
            dayLength =  dayLength * 1.50f;
            currentTime = 0;
            Instantiate(blight, transform.position, transform.rotation);

        }
        uiText.text = day.ToString();
    }



}
