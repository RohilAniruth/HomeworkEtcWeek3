using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D( Collider2D other)
    {
        GameObject scoreH = GameObject.Find("ScoreHolder");
        scoreH.GetComponent<ScoreTracker>().addScore(1000);
        GetComponent<AudioSource>().Play();



    }
	
	}