using UnityEngine;

public class UI_Follow : MonoBehaviour
{
    [Header("Target")]
    public Transform playerHead;

    [Header("Settings")]
    public bool yAxisOnly = true;
    public bool reverseForward = false; // turn on if the canvas faces backwards
    public float rotationSpeed = 8f;

    void Start()
    {
        if (playerHead == null && Camera.main != null)
        {
            playerHead = Camera.main.transform;
        }
    }

    void LateUpdate()
    {
        if (playerHead == null) return;

        Vector3 direction = playerHead.position - transform.position;

        if (yAxisOnly)
        {
            direction.y = 0f;
        }

        if (direction.sqrMagnitude < 0.0001f) return;

        Quaternion targetRotation = Quaternion.LookRotation(direction.normalized, Vector3.up);

        if (reverseForward)
        {
            targetRotation *= Quaternion.Euler(0f, 180f, 0f);
        }

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}

