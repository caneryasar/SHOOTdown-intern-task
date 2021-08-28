using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {
    
    BallStatus spawnAgain;
    ScoreKeeper score;


    private void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Box") {

            Destroy(collider.gameObject);

            score = FindObjectOfType<ScoreKeeper>();
            score.ChangeScore();
        }

        if(collider.tag == "Player") {

            spawnAgain = FindObjectOfType<BallStatus>();
            spawnAgain.ReturnBall();
        }
    }
}
