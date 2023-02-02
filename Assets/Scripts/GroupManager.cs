using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupManager : MonoBehaviour
{
    public Trooptype troopType;
    public List<GameObject> troopPrefabs= new List<GameObject>();
    public List<GameObject> aliveTroops = new List<GameObject>();
    public GroupManager enemyGroupManager;
    private void Awake()
    {
        if (troopType == Trooptype.Player)
        {
            enemyGroupManager = GameObject.FindGameObjectWithTag("Enemy").GetComponent<GroupManager>();
        }
        else
        {
            enemyGroupManager = GameObject.FindGameObjectWithTag("Player").GetComponent<GroupManager>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 3; i++)
        //{
        //    var newTroop = Instantiate(troopPrefabs[0],transform.position, Quaternion.identity);
        //    newTroop.GetComponent<TroopMovement>().SetGroupManager(enemyGroupManager);  
        //    aliveTroops.Add(newTroop);
        //}
        foreach (var item in aliveTroops)
        {
            item.GetComponent<TroopMovement>().SetGroupManager(enemyGroupManager);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

