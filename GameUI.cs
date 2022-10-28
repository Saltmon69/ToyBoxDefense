using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshPro _money;
    [SerializeField] private TextMeshPro _wave;
    [SerializeField] private TextMeshPro _playerlife;

    [SerializeField] private Player_Data _playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerlife.SetText(Convert.ToString(_playerData.playerLife));
        _wave.SetText(Convert.ToString(_playerData.wave));
        _money.SetText(Convert.ToString(_playerData.money));
    }
}
