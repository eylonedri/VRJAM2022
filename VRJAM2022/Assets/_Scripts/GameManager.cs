using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public int currentlevel = 0;
    public List<GameObject> levels;

    public float delayToLevelCompletedEvents = 0;
    public UnityEvent LevelFinishedEvents;
    public UnityEvent DelayedLevelFinishedEvents;
    
    public void FinishLevel()
    {
        LevelFinishedEvents.Invoke();
        StartCoroutine("LevelFinishDelayed");

        levels[currentlevel].gameObject.SetActive(false);
        
    }


    IEnumerator LevelFinishDelayed()
    {
        yield return new WaitForSeconds(delayToLevelCompletedEvents);

        DelayedLevelFinishedEvents.Invoke();
        currentlevel++;
        levels[currentlevel].gameObject.SetActive(true);
    }

}
