using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    int goalComp;
    int goalPlay;
    Text scoreText;
    void Start()
    {
        
        scoreText = GetComponent<Text>();
        DontDestroyOnLoad(scoreText);
        
    }
    void Update()
    {
        goalComp = GameObject.FindGameObjectWithTag("WallPlay").GetComponent<WallPlayer>().goalPlay;
        goalPlay = GameObject.FindGameObjectWithTag("WallComp").GetComponent<WallComputer>().goalComp;
        scoreText.text = "Player " + goalPlay + " : " + goalComp + " Computer"; 
    }
}
