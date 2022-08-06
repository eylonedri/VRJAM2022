using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnenemyKilled;

    public CupManger cupManger;
    public Transform target;
    NavMeshAgent agent;
    public LayerMask whatIsGround, whatIsPlayer;
    public bool cupingame = false;
    public GameObject conffeti = null;
    public int win = 0;

    // patroling
    public Vector3 walkPoint;
    bool walkpointSet;
    public float walkPointRange;

    //states
    public float lookRadius = 10f;
    public bool playerInSightRange;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = null;

    }


    void Update()
    {

        if (cupManger.CupInGame(cupingame))
        {
            Debug.Log("cupingame "+cupingame);
            target = GameObject.Find("cup").transform;
        }
        playerInSightRange = Physics.CheckSphere(transform.position, lookRadius, whatIsPlayer);
        if (!playerInSightRange) Patrolling();
        if (playerInSightRange) Chasing();


        /*float distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.transform.position);
        }*/
    }


    private void Patrolling()
    {
        if (!walkpointSet) searchWalkPoint();

        if(walkpointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;   

        if(distanceToWalkPoint.magnitude < lookRadius)
            walkpointSet = false;

    }
    private void searchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomx = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomx, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkpointSet = true;
    }

    private void Chasing()
    {
        agent.SetDestination(target.position);
        
    }

    public void Die()
    {
        Debug.Log("Lets Die Together!!!");
        Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        
        if(OnenemyKilled != null)
        {
            OnenemyKilled();
            win++;
        }

        if(win == 3)
        {
            conffeti.active = true;
        }


    }
    // Update is called once per frame
    
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
