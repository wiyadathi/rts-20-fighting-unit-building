using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISupport : MonoBehaviour
{
    [SerializeField] private List<GameObject> fighters = new List<GameObject>(); //fighter
    public List<GameObject> Fighters { get { return fighters; } }

    [SerializeField] private List<GameObject> builders = new List<GameObject>(); //builder
    public List<GameObject> Builders { get { return builders; } }

    [SerializeField] private List<GameObject> workers = new List<GameObject>(); //worker
    public List<GameObject> Workers { get { return workers; } }

    [SerializeField] private Faction faction;
    public Faction Faction { get { return faction; } }

    
    
    // Start is called before the first frame update
    void Start()
    {
        faction = GetComponent<Faction>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Refresh()
    {
        fighters.Clear();
        workers.Clear();

        foreach (Unit u in faction.AliveUnits)
        {
            if (u.IsBuilder) //if it is a builder
                builders.Add(u.gameObject);
            
            if (u.IsWorker) //if it is a worker
                workers.Add(u.gameObject);

            if (!u.IsBuilder && !u.IsWorker) //if it is a fighter
                fighters.Add(u.gameObject);
        }
    }

}
