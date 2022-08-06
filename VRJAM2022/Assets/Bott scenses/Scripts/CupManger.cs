using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManger : MonoBehaviour
{
    #region Singleton

    public static CupManger instance;

    public void Awake()
    {
        instance = this;
    }

    #endregion

   
    public int index = 3;
    public EnemyManger enemyManger;
    public GameObject Confeti = null;
    public bool CupInGame(bool cupingame)
    {

        if (index > 0) cupingame = true;
        else
        {
            cupingame = false;
            Confeti.SetActive(true);
        }
        if(index <= 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("Respawn"));
            
        }


        return cupingame;
      
    }

    public void indexlow()
    {
        index--;
        Debug.Log(index);



    }




}
