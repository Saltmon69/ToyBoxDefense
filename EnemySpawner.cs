using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Variables diverses
    [SerializeField] private GameObject enemyprefab;
    [SerializeField] public int mobkilled;
    [SerializeField] private double mobtospawn;
    



    // Variables pour les temps de spawn
    [SerializeField] private float cooldown = 3f;
    private float spawndelay = -9999f;

    // Variables gestion des waves et de la difficulté

    [SerializeField] private Player_Data playerData;
    private AIPath enemySpeed;
    



    void Start()
    {
        mobkilled = 0;
        mobtospawn = 3;
        
        

    }

    
    void Update()
    {
        
       if (mobkilled < mobtospawn)
        {
            if (Time.time > spawndelay + cooldown)
            {
                GameObject.Instantiate(enemyprefab, transform.parent.parent.transform);
               
                mobkilled++;

                spawndelay = Time.time;
            }
        }

        if (mobkilled == mobtospawn)
        {
            playerData.wave++;
            enemySpeed.maxSpeed *= 1.25f;
            mobkilled = 0;
            mobtospawn = mobtospawn * 2f;
        }

        if (playerData.wave == 20 & mobkilled == mobtospawn)
        {
            playerData.gamewin = true;
        }
        

    }
}
