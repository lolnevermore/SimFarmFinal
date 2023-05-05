using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    Vector3 rotateLight = Vector3.zero;
    float degree = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateLight.x = degree * Time.deltaTime;
        transform.Rotate(rotateLight, Space.World);
    }

     
}
