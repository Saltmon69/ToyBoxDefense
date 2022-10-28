using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "ScriptableObjects/Player Data")]
public class Player_Data : ScriptableObject
{

    public int money;
    public int playerLife;
    public int wave;
    public bool gamelost;
    public bool gamewin;

}
