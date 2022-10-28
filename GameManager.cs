using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player_Data _playerData;

    [SerializeField] private GameObject losescreen;
    [SerializeField] private GameObject winscreen;
    [SerializeField] private GameObject mainmenu;

    [SerializeField] private AudioSource winMusic;
    [SerializeField] private AudioSource loseMusic;
    // Start is called before the first frame update
    void Start()
    {
        _playerData.gamelost = false;
        _playerData.gamewin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerData.gamelost)
        {
            losescreen.SetActive(true);
            //loseMusic.Play();
            Invoke("GameLost", 2f);
        }
        if (_playerData.gamewin)
        {
            winscreen.SetActive(true);
            //winMusic.Play();
            Invoke("GameWin", 2f);
        }
    }

    private void GameWin()
    {
        winscreen.SetActive(false);
        mainmenu.SetActive(true);
    }

    private void GameLost()
    {
        losescreen.SetActive(false);
        mainmenu.SetActive(true);
    }
}
