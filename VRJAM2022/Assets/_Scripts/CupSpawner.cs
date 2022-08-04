using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupSpawner : MonoBehaviour
{

    public CupManager cupManager;
    public Transform cupSpawnPoint;
    public GameObject redCup;
    public bool cupIndexStatus;
    private bool isColliding;

    /*
    private void OnTriggerExit(Collider other)
    {  
        if (isColliding)
        {
            if (other.gameObject.tag == "Cup")
            {
                cupManager.CheckCupIndex(cupIndexStatus);
            }
            Debug.Log("cupIndexStatus " + cupIndexStatus);
        }
        isColliding = true;
    }

    private void Update()
    {
        isColliding = false;
    }

    */

    void OnTriggerEnter(Collider hitObject)
    {
        if (isColliding) return;
        isColliding = true;
        if (hitObject.tag == "Cup")
        {
         //   cupManager.CheckCupIndex(cupIndexStatus);
            Debug.Log("cupIndexStatus " + cupIndexStatus);
        }
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        isColliding = false;
    }

}

