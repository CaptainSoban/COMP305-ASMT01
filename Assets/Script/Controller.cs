/* Source File Name: Controller.cs
 * Author: Xiaoyu Wang
 * Last Modified Date: Oct 5th 2015
 * Description: Make the car move and add some soundtracks.
 * Version: 2
 * 
 * Class: Controller
 * Method: KeyInput bdCheck OnTriggerEnter2D
 * 
 * */
using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class Controller : MonoBehaviour {
	public float speed;
	public Boundary bd;
    public GameObject thIn;
    private Vector2 newPosition = new Vector2(0.0f, 0.0f);

    private AudioSource[] audioS;
    private AudioSource EngineS, DriftS, CrashS;

	// Use this for initialization
	void Start () {
        this.audioS = this.GetComponents<AudioSource>();
        this.EngineS = this.audioS[0];
        this.DriftS = this.audioS[1];
        this.CrashS = this.audioS[2];
	}
	
	// Update is called once per frame
	void Update () {
		this.KeyInput ();
	}

	private void KeyInput () {
		this.newPosition = gameObject.GetComponent<Transform> ().position;
		if (Input.GetAxis ("Horizontal") > 0) {
			this.newPosition.x += this.speed;
            this.DriftS.Play();
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			this.newPosition.x -= this.speed;
            this.DriftS.Play();
		}
		if (Input.GetAxis ("Vertical") > 0) {
			this.newPosition.y += this.speed;
		}
		if (Input.GetAxis ("Vertical") < 0) {
			this.newPosition.y -= this.speed;
		}
		this.bdCheck ();
		gameObject.GetComponent<Transform> ().position = this.newPosition;
	}

	private void bdCheck () {
		if (this.newPosition.x < this.bd.xMin) {
			this.newPosition.x = this.bd.xMin;
		}
		if (this.newPosition.x > this.bd.xMax) {
			this.newPosition.x = this.bd.xMax;
		}
		if (this.newPosition.y < this.bd.yMin) {
			this.newPosition.y = this.bd.yMin;
		}
		if (this.newPosition.y > this.bd.yMax) {
			this.newPosition.y = this.bd.yMax;
		}
	}

    //lose life when crash
    void OnTriggerEnter2D(Collider2D other) {
        this.CrashS.Play();
        Life life = thIn.GetComponent<Life>();
        life.live--;
        
        
        Debug.Log("ss");
    }
}

