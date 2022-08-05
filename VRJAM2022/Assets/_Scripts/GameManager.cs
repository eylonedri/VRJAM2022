using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public GameObject redCup;
    public bool LevelStatus;
    public int levelNumber;
    public List<GameObject> levels;

    public float levelCompletedEventWithDelay;
    public UnityEvent LevelCompletedEventWithDelay;

    public UnityEvent LevelCompletedEvent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cup")
        {
            LevelCompletedEvent.Invoke();
            StartCoroutine("TriggerEnteredDelayeddd");
        }
    }


}
