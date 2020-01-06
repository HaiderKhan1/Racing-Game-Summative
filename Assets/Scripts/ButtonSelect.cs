using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSelect : MonoBehaviour
{

    //go the game scene
    public void playGame()
    {
        SceneManager.LoadScene(2);
    }
    
    // go to instruactions to screen 
    public void Instructions()
    {
        SceneManager.LoadScene(1);
    }

    //return to main screen
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
