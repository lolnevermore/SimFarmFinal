using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject score;
    public GameObject enemy;
    float enemyMSpeed;
    float enemyRSpeed;
    public GameObject player;
    int PScore;
    float playerSpeed;
    public GameObject PotPlant;
    public GameObject CarPlant;
    public GameObject CornPlant;
    float growPot;
    float growCar;
    float growCorn;
    public GameObject Success;

    void Start()
    {
        player = GameObject.Find("Player");
        playerSpeed = player.GetComponent<Movement>().speed;
        PotPlant = GameObject.FindGameObjectWithTag("PotatoSeed");
        CarPlant = GameObject.FindGameObjectWithTag("CarrotoSeed");
        CornPlant = GameObject.FindGameObjectWithTag("CornSeed");
        growPot = PotPlant.GetComponent<PlantGrowth>().potatoTime;
        growCar = CarPlant.GetComponent<PlantGrowth>().carrotTime;
        growCorn = CornPlant.GetComponent<PlantGrowth>().cornTime;
        score = GameObject.Find("ScoreManager");
        PScore = score.GetComponent<Score>().score;
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyMSpeed = enemy.GetComponent<Enemy>().moveSpeed;
        enemyRSpeed = enemy.GetComponent<Enemy>().runSpeed;

        Success.SetActive(false);

    }

    private void Update()
    {
        score.GetComponent<Score>().score = PScore;
    }
    public void UpgradePlayerMovespeed()
    {
        PScore = PScore - 200;
        player.GetComponent<Movement>().speed = playerSpeed * 2.5f;
    }

    public void UpgradePlantGrowth()
    {
        PScore = PScore - 150;
        PotPlant.GetComponent<PlantGrowth>().potatoTime = growPot * 0.5f;
        CarPlant.GetComponent<PlantGrowth>().carrotTime = growCar * 0.5f;
        CornPlant.GetComponent<PlantGrowth>().cornTime = growCorn * 0.5f;
    }

     public void DegradeFoxSpeed()
    {
        PScore = PScore - 100;
        enemy.GetComponent<Enemy>().moveSpeed = enemyMSpeed * 0.6f;
        enemy.GetComponent<Enemy>().runSpeed = enemyRSpeed * 0.6f;
    }

    public void ContinueRunback()
    {
        Time.timeScale = 1f;
        Success.SetActive(false);
    }
}
