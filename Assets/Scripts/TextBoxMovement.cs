using UnityEngine;

public class TextBoxMovement : MonoBehaviour
{
    [SerializeField]
    public string inputText;

    [SerializeField]
    private int _walkSpeed = 10000;

    [SerializeField]
    private int _rotateSpeed = 5;

    [SerializeField]
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        switch (inputText)
        {
            case "walk":
            case "forward":
                Debug.Log("WalkForward");
                _rb.linearVelocity = Vector3.zero;
                _rb.AddForce(transform.forward * (_walkSpeed * Time.deltaTime));
                break;

            case "backwards":
                Debug.Log("Backwards");
                _rb.linearVelocity = Vector3.zero;
                _rb.AddForce(transform.forward * (-_walkSpeed * Time.deltaTime));
                break;

            case "left":
                Debug.Log("TurnLeft");
                _rb.angularVelocity = Vector3.zero;
                _rb.AddTorque(Vector3.up * (-_rotateSpeed * Time.deltaTime));
                break;

            case "right":
                Debug.Log("TurnRight");
                _rb.angularVelocity = Vector3.zero;
                _rb.AddTorque(Vector3.up * (_rotateSpeed * Time.deltaTime));
                break;

            case "stop":
                Debug.Log("Stop");
                _rb.linearVelocity = Vector3.zero;
                _rb.angularVelocity = Vector3.zero;
                break;

        }
    }
}
