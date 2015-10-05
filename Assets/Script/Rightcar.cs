/* Source File Name: Rightcar.cs
 * Author: Xiaoyu Wang
 * Last Modified Date: Oct 5th 2015
 * Description: Define the right car respawn and move.
 * Version: 2
 * 
 * Class: Rightcar
 * Method: resetit
 * 
 * */
using UnityEngine;
using System.Collections;

public class Rightcar : MonoBehaviour {
    private float cspeed;
    private float speed;
    private Vector2 cposition;
    // Use this for initialization
    void Start()
    {
        resetit();
    }

    // Update is called once per frame
    void Update()
    {
        cposition.y = cposition.y - speed;
        gameObject.GetComponent<Transform>().position = cposition;
        if (cposition.y <= -2660)
        {
            cposition.y = -2660;
        }
    }
    void resetit()
    {
        float r = Random.value;
        float r2 = Random.value;
        cposition.y = 2660.0f;

        if (r > 0.6 && r <= 1)
        {
            cposition.x = 350.0f;
        }
        else
        {
            if (r > 0.2 && r <= 0.6)
            {
                cposition.x = 870.0f;
            }
            else
            {
                cposition.x = 1360.0f;
            }
        }
        gameObject.GetComponent<Transform>().position = cposition;
        if (r >= 0 && r <= 0.2)
        {
            speed = 65 - 25 * r2;
        }
        else
        {
            speed = 65 - 45 * r2;
        }
    }
}
