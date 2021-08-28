using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreReturn : MonoBehaviour {

    TextMeshProUGUI scores;
    ScoreKeeper points;

    void Start() {

        scores = GetComponent<TextMeshProUGUI>();
        points = FindObjectOfType<ScoreKeeper>();
    }


    void Update() {

        scores.text = points.FinalScore().ToString();
    }
}
