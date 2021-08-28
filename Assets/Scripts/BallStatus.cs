using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStatus : MonoBehaviour {

    [Header("Force and Position")]
    [SerializeField] Transform ballPos;
    [SerializeField] float throwForceInX = 2.5f;
    [SerializeField] float throwForceInY = 1f;
    [SerializeField] float throwForceInZ = 300f;

    [Header("Player Specs")]
    [SerializeField] int lives = 5;
    [SerializeField] AudioClip swipeSFX;
    [SerializeField] [Range(0, 2)] float swipeSFXVolume = 1f;
    [SerializeField] AudioClip spawnSFX;
    [SerializeField] [Range(0, 2)] float spawnSFXVolume = 0.5f;

    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    Vector3 spawn;
    Rigidbody ballBody;


    void Start() {

        ballBody = GetComponent<Rigidbody>();

        spawn = transform.position;
    }

    void Update() {

        if(lives <= 0) {

            ballBody.isKinematic = true;
        }
    }

    void OnMouseDown() {

        touchTimeStart = Time.time;

        startPos = Input.mousePosition;
    }

    void OnMouseUp() {

        touchTimeFinish = Time.time;
        timeInterval = touchTimeFinish - touchTimeStart;

        endPos = Input.mousePosition;
        direction = endPos - startPos;

        ballBody.isKinematic = false;

        ballBody.AddForce(direction.x * throwForceInX, direction.y * throwForceInY, throwForceInZ / timeInterval);

        AudioSource.PlayClipAtPoint(swipeSFX, Camera.main.transform.position, swipeSFXVolume);
    }

    public void ReturnBall() {

        if (lives > 0) {

            lives -= 1;

            ballBody.isKinematic = true;

            ballPos.transform.position = spawn;
            ballBody.velocity = Vector3.zero;

            AudioSource.PlayClipAtPoint(spawnSFX, Camera.main.transform.position, spawnSFXVolume);
        }
    }

    public int ReturnLives() { return lives; }
}
