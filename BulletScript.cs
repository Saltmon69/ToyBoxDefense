using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy_Script>() == true)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
