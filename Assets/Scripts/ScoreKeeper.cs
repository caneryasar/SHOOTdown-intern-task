using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    int score = 0;
    int boxPoint = 96;
    static int finalScore;

    public void ChangeScore() {
        
        score += boxPoint;
        finalScore = score;   
    }

    public int ReturnScore() { return score; }

    public int FinalScore() { return finalScore; }
}
