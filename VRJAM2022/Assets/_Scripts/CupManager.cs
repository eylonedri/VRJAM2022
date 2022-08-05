using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManager : MonoBehaviour
{
    public Transform cupSpawnPoint;
    public GameObject redCup;
    public float delayTime = 1.5f;

    public void SpawnCup()
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
        Instantiate(redCup, cupSpawnPoint.position, Quaternion.identity);
    }
}


