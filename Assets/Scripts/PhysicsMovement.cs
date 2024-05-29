using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float amplitude = 1f;
    public float frequency = 1f;

    private void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = Mathf.Sin(Time.time * frequency) * amplitude;
        rb.velocity = velocity;
    }

}
