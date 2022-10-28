using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameUI : MonoBehaviour
{
    private TextMeshProUGUI MoneyText;
    private TextMeshProUGUI LifeText;
    [SerializeField] private GameObject MoneyObject;
    [SerializeField] private GameObject LifeObject;

    [SerializeField] private Player_Data playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        MoneyText = MoneyObject.GetComponent<TextMeshProUGUI>();
        LifeText = LifeObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.SetText(playerData.money.ToString());
        LifeText.SetText(playerData.playerLife.ToString());
    }
}
