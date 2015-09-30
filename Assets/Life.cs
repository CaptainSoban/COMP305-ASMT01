using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Life : MonoBehaviour {
    public int live = 3;
    private Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "Lives Remain: " + live;
        if (live <= 0) {

        }
	}
}
