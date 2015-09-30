using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {
    public GameObject Leftcar;
    public GameObject Rightcar;
    int ttimer = 0;
    int tcounter = 5;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        ttimer++;
        float a = Random.value;
        float b = Random.value;
        if (ttimer == tcounter) {
            if (a < 0.8) {
                GameObject ps1 = (GameObject)Instantiate(Leftcar);
                Destroy(ps1, 2.0f);
            }

            if (b < 0.9) {
                GameObject ps2 = (GameObject)Instantiate(Rightcar);
                Destroy(ps2, 4.0f);
            }

            tcounter = tcounter + 50;
        }
	}
}
