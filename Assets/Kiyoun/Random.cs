using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn(){
        int x = UnityEngine.Random.Range((int)c.transform.position.x-2,(int)c.transform.position.x+2);
        int y = UnityEngine.Random.Range((int)c.transform.position.y-2,(int)c.transform.position.y+2);
        //if(x>10||x<-10||y>5||y<-5) Spawn();
        transform.position=new Vector2(x,y);
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.tag=="Obstacles")
            Spawn();
        if(other.tag=="Player")
            Spawn();
    }
}
