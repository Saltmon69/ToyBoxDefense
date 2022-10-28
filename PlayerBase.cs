using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerBase : MonoBehaviour
{
    [SerializeField] private Player_Data playerData;

    public GameObject HitVFX;
    public GameObject LastHitVFX;

    private void Update()
    {
        if (playerData.playerLife == 0)
        {
            playerData.gamelost = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInChildren<Enemy_Script>())
        {
            Hit();
            
            GameObject.Destroy(other.transform.parent);
        }
    }

    private void Hit()
    {
        playerData.playerLife--;
        Destroy(GameObject.Instantiate(HitVFX, gameObject.transform), 0.5f);
        
        
    }

    private void LastHit()
    {
        Destroy(GameObject.Instantiate(LastHitVFX, gameObject.transform), 0.5f);
        playerData.playerLife--;
        playerData.gamelost = true;
        Destroy(gameObject, 0.5f);
    }
}
