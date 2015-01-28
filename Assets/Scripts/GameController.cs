using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
     public GameObject cloth;
    float timer;
    float resTime = 3f;
    public Vector3 range;
	void Start () 
    {
        
	}
	
	
	void Update () 
    {
        timer += Time.deltaTime;
        
        if (timer >= resTime)
        {
            Respawn();
        }
        if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel(1);
        }
	}
    void Respawn()
    {
        Instantiate(cloth, new Vector3(Random.Range(-8f,8f),0.0f,Random.Range(-17f,-3f)),Quaternion.identity);
        timer = 0.0f;
    }
}
