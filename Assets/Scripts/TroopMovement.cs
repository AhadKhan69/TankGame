using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TroopMovement : MonoBehaviour
{
    public Trooptype troopType;
    public NavMeshAgent agent;
    public Transform target;
    public GroupManager groupManager;
    private void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(new Vector3(transform.position.x, groupManager.aliveTroops[0].gameObject.transform.position.y, groupManager.aliveTroops[0].gameObject.transform.position.z));
    }
    public void SetGroupManager(GroupManager groupManager)
    {
        this.groupManager = groupManager;   
    }

}
 [System.Serializable] public enum Trooptype
{
    Enemy,Player
}