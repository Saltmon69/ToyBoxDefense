using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UIElements.Button;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    //Boutons
    
    public Button playButton;
    public Button levelButton;
    public Button leaveButton;
    public Button optionButton;
    
    //Niveaux, groupe d'UI, etc...

    public GameObject mainMenu;
    public GameObject game;
    public GameObject levelMenu;
    public GameObject optionMenu;
    public GameObject niveaux1;
    
    public GameObject gameUI;

    public GameObject loseScreen;
    public GameObject winscreen;
    public GameObject pauseScreen;
    
    //Gamefeel bouton

    public AudioSource buttonclick;

    void Start()
    {
        mainMenu.SetActive(true);
        
        
        game.SetActive(false);
        niveaux1.SetActive(false);
        loseScreen.SetActive(false);
        winscreen.SetActive(false);
        gameUI.SetActive(false);
        levelMenu.SetActive(false);
        optionMenu.SetActive(false);
        pauseScreen.SetActive(false);
    }


    void Update()
    {
        if (mainMenu.activeSelf == true)
        {
            game.SetActive(false);
            niveaux1.SetActive(false);
            loseScreen.SetActive(false);
            winscreen.SetActive(false);
            levelMenu.SetActive(false);
            optionMenu.SetActive(false);
            gameUI.SetActive(false);
            pauseScreen.SetActive(false);
            
        }
        
        
        
    }

    public void PlayButton()
    {
        buttonclick.Play();
        mainMenu.SetActive(false);
        
        
        game.SetActive(true);
        niveaux1.SetActive(true);
        gameUI.SetActive(true);
        
    }

    public void LevelButton()
    {
        buttonclick.Play();
        mainMenu.SetActive(false);
        
        levelMenu.SetActive(true);
    }

    public void OptionButton()
    {
        buttonclick.Play();
        mainMenu.SetActive(false);
        
        optionMenu.SetActive(true);
        
    }

    public void QuitButton()
    {
        buttonclick.Play();
        Application.Quit();
        
        
    }

    public void ReturnToMenu()
    {
        buttonclick.Play();
        mainMenu.SetActive(true);
    }

    public void LoadLevel1()
    {
        buttonclick.Play();
        levelMenu.SetActive(false);
        mainMenu.SetActive(false);
        
        
        game.SetActive(true);
        niveaux1.SetActive(true);
        gameUI.SetActive(true);
        
    }

    public void LoadLevel2()
    {
        buttonclick.Play();
        levelMenu.SetActive(false);
        mainMenu.SetActive(false);
        niveaux1.SetActive(false);
        
        game.SetActive(true);
        
        gameUI.SetActive(true);
        
    }

    public void ReloadScene()
    {
        buttonclick.Play();
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    
}
