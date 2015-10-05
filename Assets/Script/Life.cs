/* Source File Name: Life.cs
 * Author: Xiaoyu Wang
 * Last Modified Date: Oct 5th 2015
 * Description: Count and display player's life.
 * Version: 2
 * 
 * Class: Life
 * Method: a
 * 
 * */
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Life : MonoBehaviour {
    public GameObject kk;
    public int live = 5;
    private Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    private Vector2 cp;

	void Update () {
        this.GetComponent<Text>().text = "Lives Remain: " + live;
        if (live < 0) {
            cp.x = 0;
            cp.y = 0;
            kk.GetComponent<Text>().text = "Game Over!";
            Invoke("a", 3.0f);
            
        }
	}

    //Restart the game
    void a () {
        Application.LoadLevel("Scene");
    }
}
