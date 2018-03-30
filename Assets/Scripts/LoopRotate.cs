using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopRotate : MonoBehaviour {

    public float speed;

	void Start () {
		
	}

	void Update () {
        this.transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        if(Input.GetMouseButtonDown(0) && GameObject.FindGameObjectWithTag("Player") != null)
        {
            if(this.transform.position.y < (GameObject.FindGameObjectWithTag("Player").transform.position.y - 7))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
