using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent_Movement : MonoBehaviour
{
    public float speed;
    public GameObject target;
    Rigidbody2D rb;
    Collider2D col;
    Vector2 v;

    bool canMove=true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col=GetComponent<Collider2D>();
        v = target.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (canMove)
        {
            rb.MovePosition(Vector2.MoveTowards(rb.position, v, speed * Time.deltaTime));
        }
    }
    void OnTriggerStay2D(Collider2D c){
        if(c.tag=="Obstacles"){
            v= new Vector2(rb.position.x-col.bounds.size.x,rb.position.y);
        }
        if(c.tag=="Enemy"){
            canMove=false;
        }
    }
    void OnTriggerExit2D(Collider2D c){
        if(c.tag=="Obstacles"){
            v = target.transform.position;
        }
    }
}
