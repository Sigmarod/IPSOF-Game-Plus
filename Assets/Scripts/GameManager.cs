
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public NewPlayerMovement mov;
    public NewPlayerMovement mov2;

    public GameObject creditsUI;

    public Text scoreText;
    public Text scoreText2;
    public int score = 0;
    bool scorebl = true;

    public bool hardcore;



    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int buildIndex = currentScene.buildIndex;
        if (buildIndex == 1)
        {
            hardcore = false;
        }
        if(buildIndex == 3)
        {
            hardcore = true;
        }
        mov.enabled = true;
        mov2.enabled = true;
        scoreText.enabled = true;
    }

    void Update()
    {
        
            if (mov.enabled && scorebl)
            {
                Invoke("scoreplus", 0.1f);
                scorebl = false;
            }

            if (gameHasEnded)
            {
                scoreText2.text = score.ToString();
            }

            if (creditsUI.active)
            {
                if (Input.GetKey("space"))
                {
                    SceneManager.LoadScene(1);
                    gameHasEnded = false;
                    score = 0;
                    mov.enabled = true;

                }
            }
        
        
    }

    void scoreplus()
    {
        score++;
        scoreText.text = score.ToString();
        scorebl = true;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
    
            mov.enabled = false;
            gameHasEnded = true;
            Invoke("load", 1);
            

        }
    }

    public void load()
    {
        
        creditsUI.SetActive(true);
        scoreText.enabled = false;
    }
}
