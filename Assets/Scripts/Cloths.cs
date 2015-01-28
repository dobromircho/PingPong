using UnityEngine;
using System.Collections;

public class Cloths : MonoBehaviour 
{
    Transform pos;
    GameObject cube;
    void Start()
    {
        pos = GetComponent<Transform>();
        cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cube.AddComponent<Rigidbody>();
        cube.rigidbody.position = pos.position;
        cube.rigidbody.useGravity = false;
        cube.transform.localScale.Set(0.5f, 0.5f, 0.5f);
        cube.collider.isTrigger = true;
        cube.tag = "Points";
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Ball")
        {
            Destroy(gameObject, 3f);
        
            cube.rigidbody.AddForce(new Vector3(Random.Range(-10f,10f),0.0f,0.0f)* 2 , ForceMode.Impulse);
            Destroy(cube, 3f);
        }
        
    }
}
