using UnityEngine;

public class BallPhysics : MonoBehaviour {
    public float mass = 1f;
    public float bounciness = 0.8f;
    public float drag = 0.1f;
    private Rigidbody rb;
    private Vector3 velocity;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        if (rb == null) {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.mass = mass;
        rb.drag = drag;
        velocity = Vector3.zero;
    }

    private void FixedUpdate() {
        ApplyPhysics();
    }

    private void ApplyPhysics() {
        // Apply gravity
        velocity += Physics.gravity * Time.fixedDeltaTime;
        // Apply velocity
        rb.velocity = velocity;
    }

    private void OnCollisionEnter(Collision collision) {
        // Bounce effect
        velocity = Vector3.Reflect(velocity, collision.contacts[0].normal) * bounciness;
    }

    public void AddForce(Vector3 force) {
        velocity += force;
    }
}