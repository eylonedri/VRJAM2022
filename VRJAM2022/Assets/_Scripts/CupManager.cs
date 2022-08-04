using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManager : MonoBehaviour
{
    public Transform cupSpawnPoint;
    public GameObject redCup;
 


   // public int cupIndex = 0;
    public float delayTime = 2;


  /*  public void CupIndexUp(){
        cupIndex++;
        Debug.Log("Cup Index Up: " + cupIndex);
    }

    public void CupIndexDown(){
        cupIndex--;
        Debug.Log("Cup Index Down: " + cupIndex);
    }

    public void CheckCupIndex(bool cupIndexStatus)
    {
        Debug.Log("Checking Cup Index: " + cupIndex);
        if (cupIndex < 20)
        {
            cupIndexStatus = true;
            SpawnCup();
        }
        else
        {
            cupIndexStatus = false;
            Debug.Log("Changed Status to False: " + cupIndex);
        }
    }
  */
    public void SpawnCup()
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
      //  Debug.Log("Changed Status to True: " + cupIndex);
        Instantiate(redCup, cupSpawnPoint.position, Quaternion.identity);
       // CupIndexUp();
    }
}


