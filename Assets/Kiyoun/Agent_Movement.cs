using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent_Movement : MonoBehaviour
{
    public float speed;
    public GameObject target;
    Rigidbody2D rb;
    Vector2 v;

    bool canMove=true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        v = target.transform.position;
        if (canMove)
        {
            rb.MovePosition(Vector2.MoveTowards(rb.position, v, speed * Time.deltaTime));
        }
    }
    void OnTriggerEnter2D(Collider2D c){
        if(c.tag=="Obstacles"){
            target.GetComponent<Random>().Spawn();
        }
        if(c.tag=="Enemy"){
            canMove=false;
        }
    }void OnTriggerStay2D(Collider2D c){
        if(c.tag=="Obstacles"){
            target.GetComponent<Random>().Spawn();
        }
    }
}
