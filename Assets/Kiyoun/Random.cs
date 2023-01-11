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
        // transform.position = new Vector2(player.transform.position.x-f,player.transform.position.y);
        transform.position = new Vector2(transform.position.x-1.5f,transform.position.y);
    }
    public void SpawnRight(){
        // transform.position = new Vector2(player.transform.position.x+f,player.transform.position.y);
        transform.position = new Vector2(transform.position.x+1.5f,transform.position.y);
    }
    public void SpawnBack(){
        //transform.position = new Vector2(player.transform.position.x,player.transform.position.y-f);
        transform.position = new Vector2(transform.position.x,transform.position.y-1.5f);
    }
    public void Spawn(){
        transform.position = (v1 - v2).normalized * 2f + v2;
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.tag=="Player"){
            Spawn();
        }
        if(other.tag=="Obstacles"){
            int i = UnityEngine.Random.Range(1,4);
            if(i==1){
                SpawnLeft();
            }
            else if(i==2){
                SpawnRight();
            }
            else{
                SpawnBack();
            }
        }            
    }
}
