using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;  //creating variable to control the gameover panel
    public GameObject tapToStart;   //will get the text "TapToStartGame"
    public GameObject scoreText;  //variable to get scoretext which is at the top of the screen!

    private void Start()
    {
        gameOverPanel.SetActive(false);//game overpanel wont be shown util Player object collides
        tapToStart.SetActive(true);  //initially the text tap to start game will be shown
        scoreText.SetActive(false);  //score wont be shown initially at the top of the screemn!
        PauseGame();// pause game method being called when the game starts!
        
    }

    //creating update method to start game when tapped on screen!
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();  //game will start when we click on the screen with mouse
        }
    }
    
    public void GameOver()//method will be called in PlayerCollision.cs and the game over panel will be shown! 
    {
        scoreText.SetActive(false);  //score wont be shown when the game will end at the top of the screemn!
        gameOverPanel.SetActive(true);  
    }

    //now we will provide functionality to both the buttons!
    public void Restart() //to reload game when rsestart button clicked!
    {
        SceneManager.LoadScene("Game");  //when restart button clicked it will reload the scene!
    }

    //Quit game method:

    public void QuitGame()
    {
        Application.Quit();
    }

    //creating method to pause game initially!:
    public void PauseGame()
    {
        Time.timeScale = 0f; //game will be paused and wont play until we click or tap on "Tap to start game" panel
    }

    //creating method to start game when we click or tap on "Tap to start game" panel !:
    public void StartGame()
    {
        scoreText.SetActive(true);  //score will be shown when the game will be in motion at the top of the screemn!
        tapToStart.SetActive(false);  // the text tap to start game will be disabled! when game starts!
        Time.timeScale = 1f; //game will be start!
    }
    public void ChangeSceneMainMenuCube1() //changes scene when back to main menu button is pressed 
    {
        SceneManager.LoadScene("MainMenuToSelectGame");
    }


}
