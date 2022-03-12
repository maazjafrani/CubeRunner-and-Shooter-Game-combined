using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//since we are working with UI element

public class Score : MonoBehaviour
{
    public Text scoreText;// creating a variable scoreText to get the text field.
    int myScore=0;

    public Text finalScoreText;  //willget the final score
   
    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();  //converting int to String and then storing it to the score text container.
        finalScoreText.text = "Score: " +myScore.ToString();// also storing the score into finalScoreText variable and showing it once game is over
        
    }
    public void AddScore(int score)  //method to increment myScore variable 
    {
        myScore = myScore + score;  

    }
}
