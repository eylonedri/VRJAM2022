using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupGame : MonoBehaviour
{

    public GameManager gameManager;
    public bool cupIsNotHeldByPlayer = true;
    public bool cupIsInCollisionWithOtherCup = false;
    public bool cupIsInCollisionWithLevelFinishMark = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (!cupIsNotHeldByPlayer && cupIsInCollisionWithOtherCup && cupIsInCollisionWithLevelFinishMark)
        {
            gameManager.FinishLevel();
        }
        
    }

    //SetUp of all functions related to Finishing a level
    public void CupIsNotHeldByPlayer()
    {
       cupIsNotHeldByPlayer = true;
    }

    public void CupIsHeldByPlayer()
    {
        cupIsNotHeldByPlayer = false;
    }

    public void SetTrueCupIsInCollisionWithOtherCup()
    {
        cupIsInCollisionWithOtherCup = true;
    }
    public void SetFalseCupIsInCollisionWithOtherCup()
    {
        cupIsInCollisionWithOtherCup = false;
    }

    public void SetTrueCupIsInCollisionWithLevelFinishMark()
    {
        cupIsInCollisionWithLevelFinishMark = true;
    }

    public void SetFalseCupIsInCollisionWithLevelFinishMark()
    {
        cupIsInCollisionWithLevelFinishMark = false;
    }

    //Setting True/False to Cup Collision with another Cup + True/False to Cup Collision with Level Finish Mark
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cup") SetTrueCupIsInCollisionWithOtherCup();
        if (collision.gameObject.tag == "LevelFinishMark") SetTrueCupIsInCollisionWithLevelFinishMark();
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Cup") SetFalseCupIsInCollisionWithOtherCup();
        if (collision.gameObject.tag == "LevelFinishMark") SetFalseCupIsInCollisionWithLevelFinishMark();
    }
}
