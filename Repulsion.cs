// Generate a repelling force ignoring only 1 object upon collision

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    public Vector3 repulsion;
    public GameObject ignore;
    private Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision) {
        foreach (ContactPoint contact in collision.contacts) {
            GameObject other = contact.otherCollider.gameObject;
            if (rb != null && other != ignore) {
                rb.AddForce(repulsion, ForceMode.Impulse);
            } else {
                Debug.LogWarning("Please add a Rigidbody component to the player");
            }
        }
    }
}