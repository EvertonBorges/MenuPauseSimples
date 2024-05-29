using UnityEngine;

public class Movement : MonoBehaviour
{

    public float amplitude = 1f;
    public float frequency = 1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position = 
            startPosition + 
            amplitude * Mathf.Sin(Time.time * frequency) * Vector3.up;
    }
}
