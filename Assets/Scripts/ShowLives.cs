using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowLives : MonoBehaviour {

    TextMeshProUGUI livesAsNum;
    BallStatus healthStatus;


    void Start() {

        livesAsNum = GetComponent<TextMeshProUGUI>();
        healthStatus = FindObjectOfType<BallStatus>();
    }

    void Update() {
        if (healthStatus.ReturnLives() >= 0) {

            livesAsNum.text = healthStatus.ReturnLives().ToString();
        }
        else {

            livesAsNum.text = "0";
        }
    }
}
