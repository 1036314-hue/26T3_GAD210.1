using UnityEngine;
using UnityEngine.InputSystem;

public class Prototype2PlayerMovement : MonoBehaviour
{
    private Vector3 _moveInput;

    private Rigidbody _rb;

    private int _moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void PlayerMovement(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector3>();
    }

    private void Update()
    {
        Vector3 direction = new Vector3(_moveInput.x, 0, _moveInput.y).normalized;
        _rb.MovePosition(_rb.position + direction * (_moveSpeed * Time.deltaTime));
    }
}
