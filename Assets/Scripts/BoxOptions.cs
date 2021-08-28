using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOptions : MonoBehaviour {

    [SerializeField] AudioClip collisionSFXBox;
    [SerializeField] AudioClip collisionSFXBall;
    [SerializeField] [Range(0, 2)] float sfxVolume = 0.25f;

    private void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.tag == "Player") {

            AudioSource.PlayClipAtPoint(collisionSFXBall, Camera.main.transform.position, sfxVolume);
        }
        else {

            AudioSource.PlayClipAtPoint(collisionSFXBox, Camera.main.transform.position, sfxVolume);
        }

    }
}
