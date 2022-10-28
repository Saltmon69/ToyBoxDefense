using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Enemy_Script : MonoBehaviour
{
    
    
    public int healthPoint;

    //public GameObject self;

    public Player_Data playerData;

    private bool dead;

    

    [SerializeField] private EnemySpawner spawner;

    [SerializeField] private Turret_Script list;

    // Visual effects

    public GameObject DeathVFX;
    public GameObject HitVFX;
    void Start()
    {
        dead = false;
        healthPoint = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(healthPoint);
        
        if (dead == false)
            if (healthPoint <= 0)
            {
                Death();
                dead = true;
            }
                
                
    }


    private void Death()
    {
        //list.enemyList.Remove(gameObject.GetComponent<Enemy_Script>());
        spawner.mobkilled++;
        playerData.money += 100;
        Destroy(GameObject.Instantiate(DeathVFX, gameObject.transform), 0.5f);
        Destroy(transform.parent.gameObject, 0.5f);
        
    }

    public void Hit()
    {
        Destroy(GameObject.Instantiate(HitVFX, gameObject.transform), 0.5f);
        healthPoint--;
    }
}
