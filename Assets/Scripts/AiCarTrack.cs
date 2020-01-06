using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCarTrack : MonoBehaviour
{

    public GameObject TheMarker;
    public GameObject WayPoint1;
    public GameObject WayPoint2;
    public GameObject WayPoint3;
    public GameObject WayPoint4;
    public GameObject WayPoint5;
    public GameObject WayPoint6;
    public GameObject WayPoint7;
    public GameObject WayPoint8;
    public GameObject WayPoint9;
    public GameObject WayPoint10;
    public GameObject WayPoint11;
    public GameObject WayPoint12;
    public GameObject WayPoint13;
    public GameObject WayPoint14;
    public GameObject WayPoint15;
    public GameObject WayPoint16;
    public GameObject WayPoint17;
    public GameObject WayPoint18;
    public GameObject WayPoint19;
    public GameObject WayPoint20;
    public GameObject WayPoint21;
    public GameObject WayPoint22;
    public GameObject WayPoint23;
    public GameObject WayPoint24;
    public GameObject WayPoint25;
    public GameObject WayPoint26;
    public GameObject WayPoint27;
    public GameObject WayPoint28;

    public int MarkTacker;
       


    // Update is called once per frame
    void Update()

    {

        //when the game start the Waypoint tracker will be 0, so simply go to the first one and keep going to the next way point 
        if(MarkTacker == 0)
        {
            TheMarker.transform.position = WayPoint1.transform.position;
        }

        if (MarkTacker == 1)
        {
            TheMarker.transform.position = WayPoint2.transform.position;
        }

        if (MarkTacker == 2)
        {
            TheMarker.transform.position = WayPoint3.transform.position;
        }

        if (MarkTacker == 3)
        {
            TheMarker.transform.position = WayPoint4.transform.position;
        }

        if (MarkTacker == 4)
        {
            TheMarker.transform.position = WayPoint5.transform.position;
        }

        if (MarkTacker == 5)
        {
            TheMarker.transform.position = WayPoint6.transform.position;
        }

        if (MarkTacker == 6)
        {
            TheMarker.transform.position = WayPoint7.transform.position;
        }

        if (MarkTacker == 7)
        {
            TheMarker.transform.position = WayPoint8.transform.position;
        }

        if (MarkTacker == 8)
        {
            TheMarker.transform.position = WayPoint9.transform.position;
        }

        if (MarkTacker == 9)
        {
            TheMarker.transform.position = WayPoint10.transform.position;
        }

        if (MarkTacker == 10)
        {
            TheMarker.transform.position = WayPoint11.transform.position;
        }
        if (MarkTacker == 11)
        {
            TheMarker.transform.position = WayPoint12.transform.position;
        }
        if (MarkTacker == 12)
        {
            TheMarker.transform.position = WayPoint13.transform.position;
        }

        if (MarkTacker == 13)
        {
            TheMarker.transform.position = WayPoint14.transform.position;
        }

        if (MarkTacker == 14)
        {
            TheMarker.transform.position = WayPoint15.transform.position;
        }

        if (MarkTacker == 15)
        {
            TheMarker.transform.position = WayPoint16.transform.position;
        }

        if (MarkTacker == 16)
        {
            TheMarker.transform.position = WayPoint17.transform.position;
        }

        if (MarkTacker == 17)
        {
            TheMarker.transform.position = WayPoint18.transform.position;
        }

        if (MarkTacker == 18)
        {
            TheMarker.transform.position = WayPoint19.transform.position;
        }

        if (MarkTacker == 19)
        {
            TheMarker.transform.position = WayPoint20.transform.position;
        }

        if (MarkTacker == 20)
        {
            TheMarker.transform.position = WayPoint21.transform.position;
        }

        if (MarkTacker == 21)
        {
            TheMarker.transform.position = WayPoint22.transform.position;
        }

        if (MarkTacker == 22)
        {
            TheMarker.transform.position = WayPoint23.transform.position;
        }

        if (MarkTacker == 23)
        {
            TheMarker.transform.position = WayPoint24.transform.position;
        }

        if (MarkTacker == 24)
        {
            TheMarker.transform.position = WayPoint25.transform.position;
        }

        if (MarkTacker == 25)
        {
            TheMarker.transform.position = WayPoint26.transform.position;
        }

        if (MarkTacker == 26)
        {
            TheMarker.transform.position = WayPoint27.transform.position;
        }

        if (MarkTacker == 27)
        {
            TheMarker.transform.position = WayPoint28.transform.position;
        }
    }

    // using the IEunmerator function, if the MarkTracker has reached 27 --> it had reached the way point 28, set it back to 0 for another lap 

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AICar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTacker += 1;
            if (MarkTacker == 27)
            {
                MarkTacker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }


}
