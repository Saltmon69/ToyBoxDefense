using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret_Script : MonoBehaviour
{
    public List<Enemy_Script> enemyList = new List<Enemy_Script>();
    private bool inRange;
    private Enemy_Script enemyLife;
    private GameObject bullet;
    

    //Pour les attaques de la tour//

    [SerializeField] float cooldown = 0.75f;
    private float attackDelay = -9999f;


    [SerializeField] private GameObject ShootVFX;
    [SerializeField] private GameObject BulletSpawner;

    [SerializeField] private GameObject HitVFX;
    //[SerializeField] private GameObject Bullet;

    [SerializeField] private AudioSource shotSound;
    [SerializeField] private AudioSource hitSound;
    //[SerializeField] private Enemy_Script BaseScript;
    //private GameObject InstantiatedBullet;




    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (enemyList.Count > 0)
            enemyLife = enemyList[0];
        if (enemyLife.IsDestroyed())
            enemyList.Remove(enemyLife);

        if (enemyLife.healthPoint == 0)
            enemyList.Remove(enemyLife);
        
        if (inRange)
        {
            
            if (Time.time > attackDelay + cooldown)
            {
                Attack();
                
                attackDelay = Time.time;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ennemi dans la zone");
        if (other.GetComponent<Enemy_Script>())
        {
            Debug.Log("Ennemi ajouter dans la liste");
            enemyList.Add(other.GetComponent<Enemy_Script>());
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ennemi hors zone");
        if (other.GetComponent<Enemy_Script>())
        {
            Debug.Log("Ennemi enlever de la liste");
            enemyList.Remove(other.GetComponent<Enemy_Script>());
            inRange = false;
        }
    }

    public void Attack()
    {
        
        enemyLife.healthPoint -= 0.2f;
        hitSound.Play();
        shotSound.Play();
        Destroy(Instantiate(HitVFX, enemyList[0].transform), 0.5f);
        GameObject.Destroy(GameObject.Instantiate(ShootVFX, BulletSpawner.transform), 0.5f);
        
        
        //InstantiatedBullet = GameObject.Instantiate(Bullet, BulletSpawner.transform);
        //InstantiatedBullet.transform.Translate(enemyLife.transform.position);
        /*if(InstantiatedBullet.activeSelf == false)
            
            enemyLife.healthPoint--;*/
        
    }


}
