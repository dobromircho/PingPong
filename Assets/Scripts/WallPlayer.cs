using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class WallPlayer : MonoBehaviour 
{
    public int goalPlay;
    public GameObject ball;
    void Start()
    {
        
    }
    public void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Ball")
        {
            ball.audio.Stop();
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            goalPlay++;
            Instantiate(ball);
        }
    }
}
