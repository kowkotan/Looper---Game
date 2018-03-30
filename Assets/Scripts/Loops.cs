using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    public GameObject loop;
    Vector2 lastPos;
    GameObject lastLoop;

    //GameObject player;

	void Start () {
        lastPos = new Vector2(0, 0);
        lastLoop = GameObject.FindGameObjectWithTag("Loop");
        //player = GameObject.FindGameObjectWithTag("Player");
	}

    public void SpawnLoop()
    {
        lastPos.y += 2;
        GameObject spawnedLoop = Instantiate(loop, lastPos, lastLoop.transform.rotation);
        lastLoop = spawnedLoop;
    }
}
