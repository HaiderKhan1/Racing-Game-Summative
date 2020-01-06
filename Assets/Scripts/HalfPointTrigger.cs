using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    //init gameobjects
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig1;
    public GameObject HalfLapTrig2;

    //the purpose of this script is patch some cheating, such as reversing into the starting pole to complete the lap, you must touch a half lap trigger to set a lap complete trigger to true 
    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true); //set the complete trigger true if either of the half lap triggers have been turned on 
        HalfLapTrig1.SetActive(false); //turn it false since we already passed it 
        HalfLapTrig2.SetActive(false);  //turn it false since we already passed it 
    }
}
