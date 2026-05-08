using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // ��]�����S�ɌŒ�i��������Ă������悤�ɂ���j
        rb.freezeRotation = true;
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        // ���͕����ɑ��x�𒼐ڐݒ�iAddForce �͎g��Ȃ��j
        Vector3 movement = new Vector3(movementX, 0, movementY);
        rb.linearVelocity = movement * speed;
    }
}
