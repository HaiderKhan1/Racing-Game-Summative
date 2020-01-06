using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

//call this script when we have finsihed a set amount of laps 
public class RaceFinish : MonoBehaviour
{
    //initlize game objects / variables
    public GameObject MyCar;
    public GameObject FinsihCam;
    public GameObject GameplayMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;

    //when we complete the 2/2 lap run this sequence 
    void OnTriggerEnter()
    {

        this.GetComponent<BoxCollider>().enabled = false; // set the box collider off so the laps don't continusally go up
        MyCar.SetActive(false); //turn my car off (Family car object is set to this variable)
        CompleteTrig.SetActive(false); //complete trigger (set to the lap complete manger/ tracker)
        CarController.m_Topspeed = 0.0f; //the AI car which came with the standard unity assets, turn it to 0
        MyCar.GetComponent<WheelDrive>().enabled = false; // access the cars WheelDrive component and sets it to false

        //in the same frame 
        //sets my car to active
        MyCar.SetActive(true);
        FinsihCam.SetActive(true);//finsih cam is the cam following the roating cube above the car
        GameplayMusic.SetActive(false);//turn off tokyo drift
        FinishMusic.Play(); //instead play the game ending music 
       
        
    }

   
}
