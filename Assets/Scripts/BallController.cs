using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour 
{
    public float force=10f;

    void Start()
    {
        rigidbody.velocity = Vector3.right * force + Vector3.forward *force;

    }
    void OnCollisionEnter()
    {
        audio.Play();
    }
}
