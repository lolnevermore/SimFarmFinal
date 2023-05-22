using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject bench;

    public Sprite FoxDwn;
    public Sprite FoxDwnHigh;
    public Sprite FoxDwnPress;
    public Sprite FoxDwnDisable;
    public Button Fox;

    public Sprite PlayerUp;
    public Sprite PlayerUpHigh;
    public Sprite PlayerUpPress;
    public Sprite PlayerUpDisable;
    public Button PlayerUpB;

    public Sprite CropUp;
    public Sprite CropUpHigh;
    public Sprite CropUpPress;
    public Sprite CropUpDisable;
    public Button CropUpB;

    void Start()
    {
        //player = GameObject.Find("Player");
        playerSpeed = player.GetComponent<Movement>().speed;
        //PotPlant = GameObject.FindGameObjectWithTag("PotatoSeed");
        //CarPlant = GameObject.FindGameObjectWithTag("CarrotoSeed");
        //CornPlant = GameObject.FindGameObjectWithTag("CornSeed");
        growPot = PotPlant.GetComponent<PlantGrowth>().potatoTime;
        growCar = CarPlant.GetComponent<PlantGrowth>().carrotTime;
        growCorn = CornPlant.GetComponent<PlantGrowth>().cornTime;
        //score = GameObject.Find("ScoreManager");
        PScore = score.GetComponent<Score>().score;
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        //enemyMSpeed = enemy.GetComponent<Enemy>().moveSpeed;
        enemyRSpeed = enemy.GetComponent<Enemy>().runSpeed;
    }

    private void Update()
    {
        score.GetComponent<Score>().score = PScore;
        if (PScore < 0)
        {
            PScore = 0;
        }

        //if (PScore < 100)
        //{
        //    PlayerUpB.image.overrideSprite = PlayerUpDisable;
        //    CropUpB.image.overrideSprite = CropUpDisable;
        //    Fox.image.overrideSprite = FoxDwnDisable;
        //}

        //if (PScore >=100 && PScore < 150)
        //{
        //    PlayerUpB.image.overrideSprite = PlayerUpDisable;
        //    CropUpB.image.overrideSprite = CropUpDisable;
        //    Fox.image.overrideSprite = FoxDwn;
        //}

        //if (PScore >= 150 && PScore < 200)
        //{
        //    PlayerUpB.image.overrideSprite = PlayerUpDisable;
        //    CropUpB.image.overrideSprite = CropUp;
        //    Fox.image.overrideSprite = FoxDwn;
        //}

        //if (PScore >= 200)
        //{
        //    PlayerUpB.image.overrideSprite = PlayerUp;
        //    CropUpB.image.overrideSprite = CropUp;
        //    Fox.image.overrideSprite = FoxDwn;
        //}
    }
    public void UpgradePlayerMovespeed()
    {
        if (PScore >= 200)
        {
            PScore = PScore - 200;
            player.GetComponent<Movement>().speed = playerSpeed * 2.5f;
        }
        //else if (PScore < 200)
        //{
        //    PlayerUpB.image.overrideSprite = PlayerUpDisable;
        //}

    }

    public void UpgradePlantGrowth()
    {
        if (PScore >= 150)
        {
            PScore = PScore - 150;
            PotPlant.GetComponent<PlantGrowth>().potatoTime = growPot * 0.5f;
            CarPlant.GetComponent<PlantGrowth>().carrotTime = growCar * 0.5f;
            CornPlant.GetComponent<PlantGrowth>().cornTime = growCorn * 0.5f;
        }
        //else if (PScore < 150)
        //{
        //    CropUpB.image.overrideSprite = CropUpDisable;

        //}
    }

     public void DegradeFoxSpeed()
    {
        if (PScore >= 100)
        {
            PScore = PScore - 100;
            //enemy.GetComponent<Enemy>().moveSpeed = enemyMSpeed * 0.6f;
            enemy.GetComponent<Enemy>().runSpeed = enemyRSpeed * 0.6f;
        }
        //else if (PScore < 100)
        //{
        //    Fox.image.overrideSprite = FoxDwnDisable;

        //}


    }


    public void ContinueRunback()
    {
        bench.GetComponent<WorkBench>().hasTriggered = false;
        Success.SetActive(false);
        Time.timeScale = 1f;
        
    }
}
