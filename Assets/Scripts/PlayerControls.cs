using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;

    float jumpHeight = 7.5f;

    public InputActionReference jump;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
