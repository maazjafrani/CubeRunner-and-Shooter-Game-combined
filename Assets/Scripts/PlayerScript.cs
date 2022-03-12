using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    
    public Rigidbody rigidbody; //creating a rigid body component as a refernce variable below so that we can use its properties using "get"
    public float force = 1000f; //force applied to move the object along Z axis forward
    public float speed = 10f;  // speed variable to move object left and right along x axis 
    public float MaxX = 4.45f; //max level till which the player cube object can move to the right along the x-axis
    public float MinX = -4.45f; //max level till which the player cube object can move to the left along the x-axis




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = transform.position;  //storing the current value of xyz postion for the player object to the variable PlayerPos in each frame.
        if (PlayerPos.x < MinX) //if left position is less that -4.45 then assign the min value which is -4.45 to the x-axis for the "PlayerCube" object so that it doesnt fall of the ground it stands on!

        {
            PlayerPos.x = MinX; //-4.45 being assigned

        }

        if (PlayerPos.x > MaxX) //if right position is greater that 4.45 then assign the max limit value which is 4.45 to the x-axis for the "PlayerCube" object so that it doesnt fall of the ground it stands on!

        {
            PlayerPos.x = MaxX; //4.45 being assigned

        }
        transform.position = PlayerPos; //edited or updated value of xyz array assigned to transform.position






        if (Input.GetKey(KeyCode.RightArrow))   //executed when right key is pressed
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime,0,0);//will move along x axis to the right when right key pressed and the object will move independetly from the framerate
        }
        if(Input.GetKey(KeyCode.LeftArrow))   //executed when left key is pressed
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);//will move along x axis to the left when left key pressed and the object will move independetly from the framerate
        }

        if (Input.GetKey(KeyCode.D))   //executed when D is pressed so it moves to right as it does when right key is pressed
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);//will move along x axis to the right when "D" pressed and the object will move independetly from the framerate
        }

        if (Input.GetKey(KeyCode.A))   //executed when A is pressed so it moves to left as it does when left key is pressed
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);//will move along x axis to the left t when "A" pressed and the object will move independetly from the framerate
        }

    }

    //below is the Fixed Update method which will execute all the code related to "Rigid Body" Component:

    private void FixedUpdate()
    {
        //using addForce method to apply force to our "Player Object":
        rigidbody.AddForce(0, 0, force * Time.deltaTime);//object will move in z axis so Time.deltaTime is given to make the object move independent from the frame rate
    }

}
