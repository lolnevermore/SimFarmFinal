using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerate : MonoBehaviour
{
    public int width = 128;
    public int height = 128;
    public int depth = 20;
    public float scale = 20f;
    public float offsetX = 100f;
    public float offsetY = 100f;

    // Start is called before the first frame update
    void Start()
    {
        offsetX = Random.Range(0f, 9999f);
        offsetY = Random.Range(0f, 9999f);

        Terrain proTerrain = GetComponent<Terrain>();
        proTerrain.terrainData = GenerateTerrain(proTerrain.terrainData);

    }

    // Update is called once per frame
    void Update()
    {
        //Terrain proTerrain = GetComponent<Terrain>();
        //proTerrain.terrainData = GenerateTerrain(proTerrain.terrainData);
        // offsetX += Time.deltaTime * 5f;
        // offsetY += Time.deltaTime * 5f;
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }

    float[, ] GenerateHeights()
    {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                heights[x, y] = AddHeight(x, y);
            }
        }
        return heights;
    }
    float AddHeight (int x, int y)
    {
        float xPos = (float)x / width * scale + offsetX;
        float yPos = (float)y / height * scale + offsetY;

        return Mathf.PerlinNoise(xPos, yPos);
    }
    
}
