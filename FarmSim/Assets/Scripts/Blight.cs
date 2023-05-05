using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blight : MonoBehaviour
{
    GameObject[] tiles;
    [SerializeField] LayerMask seedLayer;
    [SerializeField] LayerMask plantLayer;    
    int spawnNum;
    // Start is called before the first frame update
    void Start()
    {
        tiles = GameObject.FindGameObjectsWithTag("Soil");
        spawnNum = Random.Range(0, tiles.Length);
        

        transform.position = new Vector3(tiles[spawnNum].transform.position.x, .3f, tiles[spawnNum].transform.position.z);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(1f, 0, 1f) * Time.deltaTime * .03f;
        foreach(Collider c in Physics.OverlapBox(transform.position, transform.lossyScale, transform.localRotation, plantLayer))
        {
            c.GetComponent<PlantBlight>().blighted = true;
        }
        if (transform.localScale.x > 6)
        {
            Destroy(gameObject);
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(transform.position, transform.lossyScale);
        Gizmos.color = Color.blue;
    }
}
