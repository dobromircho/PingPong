using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed ;
    public float ballSpeed;
    float moveVertical;
    GameObject ball;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        moveVertical = Input.GetAxisRaw("Vertical");
        rigidbody.velocity = new Vector3(0.0f, 0.0f, moveVertical * speed);
        
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
            ball.rigidbody.AddForce(Vector3.right * ballSpeed);
        }
    }
   
}
