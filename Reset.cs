using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public float threshold = -5f;
    GameObject blackCube;
    GameObject yellowCube, otherCubes, orangeCube;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < threshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        blackCube = GameObject.FindWithTag("blackCube");
        if (blackCube == null)
        {
            SceneManager.LoadScene("Lose1");

        }
        yellowCube = GameObject.FindWithTag("yellowCube");
        otherCubes = GameObject.FindWithTag("otherCubes");
        orangeCube = GameObject.FindWithTag("orangeCube");
        if (yellowCube == null && otherCubes == null && orangeCube == null)
        {
            SceneManager.LoadScene("Win");
        }


    }

}
