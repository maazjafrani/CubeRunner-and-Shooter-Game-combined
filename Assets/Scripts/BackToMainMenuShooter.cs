using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenuShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSceneMainMenuShooter() //changes scene when back to main menu button is pressed 
    {
        SceneManager.LoadScene("MainMenuToSelectGame");
    }
}
