using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yellow : MonoBehaviour
{
    

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            SceneManager.LoadScene("Lose2");
        }
    }


}
