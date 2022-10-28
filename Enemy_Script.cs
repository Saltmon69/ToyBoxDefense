using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class Enemy_Script : MonoBehaviour
{
    
    
    public float healthPoint;

    //public GameObject self;

    public Player_Data playerData;

    private bool dead;

    

    [SerializeField] private EnemySpawner spawner;

    [SerializeField] private Turret_Script list;

    // Visual effects

    public GameObject DeathVFX;
    public GameObject HitVFX;
    
    
    //Health bar
    [SerializeField] private Image healthbar;
    [SerializeField] private GameObject healthbarObject;
    [SerializeField] private GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        dead = false;
        healthPoint = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(healthPoint);
        healthbarObject.transform.LookAt(cam.transform.position);
        healthbar.fillAmount = healthPoint;
        
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
        playerData.money += 50;
        Destroy(GameObject.Instantiate(DeathVFX, gameObject.transform), 0.5f);
        Destroy(transform.parent.gameObject, 0.5f);
        
    }

    public void Hit()
    {
        Destroy(GameObject.Instantiate(HitVFX, gameObject.transform), 0.7f);
        
        healthPoint--;
    }
}
