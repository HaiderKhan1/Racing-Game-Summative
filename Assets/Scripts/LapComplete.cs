using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig1;
    public GameObject HalfLapTrig2;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsCompleted;

   
    public GameObject RaceFinish;


    void Update()
    {

        //if the Laps completed is 1 then set the finish race script to true 
        // to run the game finish script have the laps 1 less the then the final numbers of laps you want to complete 
        if (LapsCompleted == 1)
        {
            RaceFinish.SetActive(true);
            
        }
    }

    void OnTriggerEnter ()
    {

        //add one to laps done

        LapsCompleted += 1;

        //displaying and calculating the seconds 
        if(LapTimer.SecondCounter <= 9)
        {
            SecondDisplay.GetComponent<Text> ().text = "0" + LapTimer.SecondCounter + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimer.SecondCounter + ".";
        }

        //minutes

        if (LapTimer.MinuteCounter <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimer.MinuteCounter + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimer.MinuteCounter + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimer.MilliCounter;

        // three player prefs are written when we complete the lap 
        PlayerPrefs.SetInt("MinSave", LapTimer.MinuteCounter);
        PlayerPrefs.SetInt("SecSave", LapTimer.SecondCounter);
        PlayerPrefs.SetFloat("MilliSave", LapTimer.MilliCounter);

        //set it to 0 after one lap 
        LapTimer.MinuteCounter = 0;
        LapTimer.SecondCounter = 0;
        LapTimer.MilliCounter = 0;


        LapCounter.GetComponent<Text>().text = "" + LapsCompleted;
        //set the half lap triggers back to true 
        HalfLapTrig1.SetActive(true);
        HalfLapTrig2.SetActive(true);
        LapCompleteTrig.SetActive(false);

    }

}
