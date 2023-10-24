// Basic camera controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    public Vector3 offsets;
    private Vector3 targetPosition;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void LateUpdate() {
        if (player != null) {
            targetPosition = player.transform.position + player.transform.TransformVector(offsets);
            transform.position = targetPosition;
            transform.LookAt(player.transform);
        }
    }
}