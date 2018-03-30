using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 0.1f;

    Vector2 target;

    private void Start()
    {
        target = new Vector2(0, -2);
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if(gameObject != null)
            {
                Jump();
            }
        }

        this.transform.position = Vector2.Lerp(this.transform.position, target, speed);
	}

    void Jump()
    {
        Vector2 tempTarget = target;
        tempTarget.y += 2;
        target = tempTarget;
        GameObject.FindGameObjectWithTag("Manager").GetComponent<Loops>().SpawnLoop();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Loop")
        {
            if(this.gameObject != null)
            {
                Destroy(this.gameObject);
                Debug.Log("dead");
            }
        }
    }
}
