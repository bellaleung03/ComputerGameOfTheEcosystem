using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LiveEntity : MonoBehaviour
{
    public Species species;
    

    public void Die(CauseOfDeath cause)
    {
                
        Destroy(gameObject);    
        Debug.Log(gameObject.name + "'s cause of death was '" + cause + "'");
              
    }
}

public enum CauseOfDeath
{
    hunger, beingEaten,
}
