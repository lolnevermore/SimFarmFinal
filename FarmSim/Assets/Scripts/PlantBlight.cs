using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBlight : MonoBehaviour
{
    public bool blighted = false;
    public bool blightledv2 = false;
    public bool blightedlv3 = false;
    float timeAfflicted = 0f;
    [SerializeField] GameObject currentModel;
    [SerializeField] GameObject blightModel;
    [SerializeField] GameObject blightlv2;
    [SerializeField] GameObject blightlv3;
    [SerializeField] GameObject blight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blighted)
        {            
            timeAfflicted += 1 * Time.deltaTime;
        }
        if (blighted && timeAfflicted > 5)
        {
            currentModel.GetComponent<MeshRenderer>().enabled = false;
            blightModel.GetComponent<MeshRenderer>().enabled = true;
        }
        if (blighted && timeAfflicted > 10)
        {
            blightModel.GetComponent<MeshRenderer>().enabled = false;
            blightlv2.GetComponent<MeshRenderer>().enabled = true;
        }
        if(blighted && timeAfflicted > 15)
        {
            blightlv2.GetComponent<MeshRenderer>().enabled = false;
            blightlv3.GetComponent<MeshRenderer>().enabled = true;
            
        }
        if(blighted && timeAfflicted > 30)
        {
            Destroy(gameObject);
            Instantiate(blight, transform.position, transform.rotation);
        }

        print((int)timeAfflicted);
    }
}
