using UnityEngine;

public class CarController : MonoBehaviour {
    public float speed = 10f;
    public float turnSpeed = 50f;

    private void Update() {
        float moveInput = Input.GetAxis("Vertical"); // Forward and backward movement
        float turnInput = Input.GetAxis("Horizontal"); // Turning left and right

        MoveCar(moveInput);
        TurnCar(turnInput);
    }

    private void MoveCar(float moveInput) {
        Vector3 movement = transform.forward * moveInput * speed * Time.deltaTime;
        transform.position += movement;
    }

    private void TurnCar(float turnInput) {
        float turnAmount = turnInput * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turnAmount, 0f);
        transform.rotation *= turnRotation;
    }
}