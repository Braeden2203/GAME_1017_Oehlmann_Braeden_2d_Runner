using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;

    float jumpHeight = 7.5f;

    public InputActionReference jump;

    float MovementSpeed = 5f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = MovementSpeed * Time.deltaTime;
        transform.Translate(MoveX, 0, 0);
    }

    private void OnEnable()
    {
        jump.action.started += Jump;
    }

    private void OnDisable()
    {
        jump.action.started -= Jump;
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);

        //Debug.Log("Jumped");
    }
}
