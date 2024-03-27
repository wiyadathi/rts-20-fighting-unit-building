using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDoNothing : AIBehaviour
{
    private float returnWeight = 0.5f;

    public override float GetWeight()
    {
        return returnWeight;
    }

    public override void Execute()
    {
        //Debug.Log("Doing Nothing");
    }

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
