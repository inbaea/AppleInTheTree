using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public GameObject goal;
    public GameObject player;
    Vector2 v1;
    Vector2 v2;
    // Start is called before the first frame update
    void Start()
    {
        v1 = goal.transform.position;
        v2 = player.transform.position;
        Spawn();
    }
    // Update is called once per frame
    void Update()
    {
        v1 = goal.transform.position;
        v2 = player.transform.position;
    }
    public void SpawnLeft(){
        transform.position = new Vector2(player.transform.position.x-2f,player.transform.position.y);
    }
    public void SpawnRight(){
        transform.position = new Vector2(player.transform.position.x+2f,player.transform.position.y);
    }
    public void Spawn(){
        transform.position = (v1 - v2).normalized * 2f + v2;
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.tag=="Player")
            Spawn();            
    }
}
