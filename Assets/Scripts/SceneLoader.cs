using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {

    [SerializeField] float delay = 3f;
    [SerializeField] float restartDelay = 1f;

    GameObject[] boxes;
    BallStatus ballStatus;

    void Start() {

        ballStatus = FindObjectOfType<BallStatus>();

        boxes = GameObject.FindGameObjectsWithTag("Box");
    }

    void Update() {

        if (ballStatus != null) {
            LoadGameOver();
        }
    }

    public void StartGame() {

        SceneManager.LoadScene("MainLevel");
    }

    public void LoadGameOver() {

        int health = ballStatus.ReturnLives();

        if (health == 0 || boxes.Length == 0) {

            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver() {

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("GameOver");
    }

    public void DelayPlayAgain() {

        Invoke("PlayAgain", restartDelay);
    }

    void PlayAgain() {

        SceneManager.LoadScene("MainLevel");
    }

    public void Quit() { Application.Quit(); }
}
