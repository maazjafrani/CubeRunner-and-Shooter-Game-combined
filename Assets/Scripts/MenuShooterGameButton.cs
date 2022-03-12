using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuShooterGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSceneShooter() //changes scene when Shooter game button is pressed 
    {
        SceneManager.LoadScene("Shooter Game");
    }
}
