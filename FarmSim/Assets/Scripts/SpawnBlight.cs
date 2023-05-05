using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlight : MonoBehaviour
{
    [SerializeField] GameObject blight;
    public int day;
    public float time;
    List<int> list = new List<int>();
    GameObject garf;
    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        garf = GameObject.Find("Timer");
        timer = garf.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(timer.day > 1 && time % 30 == 0)
        {

           
                Instantiate(blight, transform.position, transform.rotation);
            
        }
    }
}
