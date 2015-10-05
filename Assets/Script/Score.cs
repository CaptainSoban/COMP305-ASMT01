/* Source File Name: Score.cs
 * Author: Xiaoyu Wang
 * Last Modified Date: Oct 5th 2015
 * Description: Count and display the score.
 * Version: 2
 * 
 * Class: Score
 * Method: 
 * 
 * */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int s = 0;
    private Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        s++;
        GameObject.Find("Canvas/Score").GetComponent<Text>().text = "Total Score: " + s;
	}
}
