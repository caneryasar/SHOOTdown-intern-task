using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] float rotationspeed = 10;

    void Update() {

        transform.Rotate(0, rotationspeed * Time.deltaTime, 0);
    }
}
