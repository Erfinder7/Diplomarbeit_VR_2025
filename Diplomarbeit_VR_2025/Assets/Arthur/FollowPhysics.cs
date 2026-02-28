using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FollowPhysics : MonoBehaviour
{
    public Transform target;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            rb.MovePosition(target.position);
        }
    }
}