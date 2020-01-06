using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    //set gameobjects
    public GameObject CarControl;
    public GameObject AICar;

    // Use this for initialization

    void Start()
    {
     
        //when the count down is happening the car is set off (the wheel drive the script responsible for moving the car) is turned off
       GameObject.Find("FamilyCar").GetComponent<WheelDrive>().enabled = true; //turn the wheel drive --> family vhiecle on 
       GameObject.Find("CarWaypointBased").GetComponent<CarAIControl>().enabled = true; //set the ai car moving script on

    } 

}
