using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInputs : MonoBehaviour
{
    private Inputs controls;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseMenu;
    void Start()
    {
        controls.Keyboard.Espace.started += _ => EspacePressed();
        controls.Keyboard.Espace.performed += _ => EspaceReleased();
        
        controls.Keyboard.Echap.started += _ => EchapPressed();
        controls.Keyboard.Echap.performed += _ => EchapReleased();
    }


    private void Awake()
    {
        controls = new Inputs();
        controls.Enable();
    }

    private void EspacePressed()
    {
        
    }

    private void EspaceReleased()
    {
        ReturnToMenu();
    }


    private void EchapPressed()
    {
        
    }

    private void EchapReleased()
    {
        PauseMenu();
    }


    private void ReturnToMenu()
    {
        mainMenu.SetActive(true);
    }

    private void PauseMenu()
    {
        switch (pauseMenu.activeInHierarchy)
        {
            case true:
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                break;
            case false:
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
    
    
}
