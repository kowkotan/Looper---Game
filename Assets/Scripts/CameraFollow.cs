using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject target;

    public float speed;
    public Vector3 offset;

	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - target.transform.position;
	}
	
	void LateUpdate () {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, speed);
	}
}
