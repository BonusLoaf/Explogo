﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public Animator logoMove;

    public Animator buttonMove;

    public Animator levelScreen;

    public Button logo;



    //Unlocks and shows the cursor so the player can use it if returning from a later scene
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }


    //If the tutorial button is click the tutorial scene is loaded
    public void tutorial()
    {

        SceneManager.LoadScene(1);

    }

    //If the level 1 button is click the tutorial scene is loaded

    public void level1()
    {

        SceneManager.LoadScene(2);

    }

    //If the level 2 button is click the tutorial scene is loaded

    public void level2()
    {

        SceneManager.LoadScene(3);

    }
    //etc
    public void level3()
    {

        SceneManager.LoadScene(4);

    }
    //etc
    public void level4()
    {

        SceneManager.LoadScene(5);

    }

    //If the Play button is click the tutorial scene is loaded
    public void playClicked()
    {

        SceneManager.LoadScene(1);

    }

    //If the back button is clicked an animator will hide the level screen
    public void backClicked()
    {

        levelScreen.SetTrigger("Back Clicked");

    }

    //If the level select button is clicked an animator will show the level screen
    public void levelSelectClicked()
    {

        levelScreen.SetTrigger("Level Screen Click");


    }

    //If the quit button is clicked the application will close
    public void quitClicked()
    {

        Application.Quit();

    }


    //When the explogo logo is clicked it is moved out of the way and the rest of the buttons brought into frame
    public void LogoClicked()
    {

        
        logoMove.SetTrigger("Logo Click");

        buttonMove.SetTrigger("Logo Click");
        

        logo.interactable = false;


    }

    
}
