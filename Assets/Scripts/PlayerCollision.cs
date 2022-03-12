using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;  //created a object or variable for Player Script file.
    public Score score;  //variable or object for Score.cs
    public GameController gameController;  //game controller script being called or get!
    public AudioSource audioSource;//getting audio source to play sound for collecting red cubes
    public AudioSource audioSource1;//getting audio source to play sound for game over!

    //creating an inbuilt method "OnTriger" which executes when two objects collide or trigger:
    private void OnTriggerEnter(Collider other) //other is used for game objects
    {
        if (other.gameObject.tag == "Collectables") //if the object with which the player object collides has a tag "Collectables" so that object will be destroyed.
        {
            audioSource.Play(); //playing sound when player collects red cubes!
            score.AddScore(1);//incrementing score by 1
            Destroy(other.gameObject);  //game object being destroyed if condition true!
        }


    }

    private void OnCollisionEnter(Collision other) //method executer when ever Player object collides with other objects:
    {
        if (other.gameObject.tag == "Obstacles") //if its a green, blue, obstacle, big obstacle object or if their tags are called "Obstacles" the the playerscript file will be disabled!
        {
            audioSource1.Play();  //audio for game over will be played when player collides with obstacles other than red cubes!
            playerScript.enabled = false;  //player Script file being disabled!
            gameController.GameOver(); //method GameOver being called! to enable game over screen!
        }
    }


}
