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
