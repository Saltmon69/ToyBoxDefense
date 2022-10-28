using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurretPlace : MonoBehaviour, IClick 
{
    [SerializeField] private GameObject turret;

    [SerializeField] private int turretPrice;
    
    [SerializeField] private Player_Data _playerData;
    
    
    public void onClickAction()
    {
        Debug.Log("Je call la fonction");
        if (_playerData.money >= turretPrice)
        {
            _playerData.money -= turretPrice;
            turret.SetActive(true);
            

        }
    }

    private void Update()
    {
        Debug.Log(_playerData.money);
    }

    private void Start()
    {
        _playerData.money = 300;
    }
}
