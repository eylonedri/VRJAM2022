using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public CupManager cupManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cup")
        {
            Destroy(other.gameObject);
            Debug.Log("Destroying Cup");
        }
    }
}
