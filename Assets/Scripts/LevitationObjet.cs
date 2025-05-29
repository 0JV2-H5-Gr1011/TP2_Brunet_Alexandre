using UnityEngine;

public class LevitationObjet : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float speed = 1f;
    public float rotationSpeed = 10f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + Vector3.up * Mathf.Sin(Time.time * speed) * amplitude;
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
