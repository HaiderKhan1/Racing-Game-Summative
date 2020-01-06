using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    /// <summary>
    /// using the animation feature provided by the unity engine
    /// using the IEnumerator funtion for the counting 
    /// uses one set of code that is reused for the rest of the seconds 
    /// </summary>
    /// 

    //set the game objects
    public GameObject Countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTime;
    public GameObject CarControls;

    //when we start call the funtion countStart 
    void Start()
    {
        StartCoroutine(CountStart());
        
    }

    IEnumerator CountStart()
    {
        //count down #3
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        Countdown.SetActive(true);

        //countdown #2
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        Countdown.SetActive(true);

        //countdown #3
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        Countdown.SetActive(true);

        //play the go audio 
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        GoAudio.Play ();

        //get the lap time running and set the car control to active 
        LapTime.SetActive(true);
        CarControls.SetActive(true);

    }
  
}
