using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;
    public Transform player;
    public float followSpeed = 5f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 targetPosition = (ball.position + player.position) / 2 + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}