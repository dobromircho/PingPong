using UnityEngine;
using System.Collections;

public class WallComputer : MonoBehaviour
{
    public int goalComp;
    public GameObject ball;
    void Start()
    {
       
    }
    public void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Ball")
        {
            ball.audio.Stop();
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            goalComp++;
            Instantiate(ball);
        }
    }
}
