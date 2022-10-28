using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerBase : MonoBehaviour
{
    [SerializeField] private Player_Data playerData;

    public GameObject HitVFX;
    public GameObject LastHitVFX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"));
        {
            if (playerData.playerLife <= 2)
            {
                Hit();
            }

            if (playerData.playerLife == 1)
            {
                LastHit();
            }
            
            GameObject.Destroy(other.gameObject);
        }
    }

    private void Hit()
    {
        Destroy(GameObject.Instantiate(HitVFX, gameObject.transform), 1f);
        playerData.playerLife--;
        
    }

    private void LastHit()
    {
        Destroy(GameObject.Instantiate(LastHitVFX, gameObject.transform), 1f);
        playerData.playerLife--;
        playerData.gamelost = true;
        Destroy(gameObject, 2f);
    }
}
