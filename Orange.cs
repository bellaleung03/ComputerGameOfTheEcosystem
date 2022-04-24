using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orange : MonoBehaviour
{
  
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1f)
        {
            Destroy(this.gameObject);
        }        
    }



}
