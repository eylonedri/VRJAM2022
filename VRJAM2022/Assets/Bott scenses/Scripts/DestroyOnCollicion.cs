using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollicion : MonoBehaviour
{

    public CupManger cupManger;
    public EnemyController EnemyController;

  

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        cupManger.indexlow();
        EnemyController.Die();
         
    }
}
