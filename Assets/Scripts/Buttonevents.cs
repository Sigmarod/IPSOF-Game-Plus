using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class Buttonevents : MonoBehaviour
{
    public NewPlayerMovement mov;
    public GameManager gm;
    bool hardcore = false;
    //Mainmenu
    public void StartGame()
    {
        if (!hardcore)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(3);
        }

    }

    public void hardcoreswitch()
    {
        if (!hardcore)
        {
            hardcore = true;
        }
        else
        {
            hardcore = false;
            EventSystem.current.SetSelectedGameObject(null);
        }
    }

    public void toTutorial()
    {
        SceneManager.LoadScene(2);
    }

    //Creditsmenu
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(y);
        SceneManager.LoadScene(y);
        gm.gameHasEnded = false;
        gm.score = 0;
        mov.enabled = true;
        
    }

    //Tutorial
    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
