using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour
{
    Transform ball;
    public float speed;
    public float ballSpeed;
    float rand;
    float moveVertical;
    NavMeshAgent nav;
    void Start()
    {
        
        nav = GetComponent<NavMeshAgent>();
       
    }

    void FixedUpdate()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        if (ball != null)
        {
           
            nav.SetDestination(new Vector3(14f,0.6f,ball.position.z));
        }
       
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Points")
        {
            rigidbody.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Ball")
        {
            ball.rigidbody.AddForce(Vector3.left * ballSpeed);

        }
    }
}
