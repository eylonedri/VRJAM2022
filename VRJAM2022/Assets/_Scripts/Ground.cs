using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public CupManager cupManager;
    bool cupIndexStatus;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cup")
        {
           /* cupManager.CheckCupIndex(cupIndexStatus);
            if (cupIndexStatus != false)
            {
                cupManager.SpawnCup();
            }
           // cupManager.CupIndexDown();
           */
            Destroy(other.gameObject);
            Debug.Log("Destroying Cup");
        }
    }
}
