using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter( Collider other)
    {
        Destroy(other.gameObject);
        //get score object and add score

        // scoreTracker.addScore();

        GameObject scoreH = GameObject.Find("ScoreHolder");
        scoreH.GetComponent<ScoreTracker>().addScore(324);

        Destroy(gameObject); //destroy self
    }
	
	}