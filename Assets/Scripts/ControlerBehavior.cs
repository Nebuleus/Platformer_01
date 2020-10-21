using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlerBehavior : MonoBehaviour
{
    private InputSettings input;
    private Vector2 direction; 
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;

    private bool isOnGround = false;
    private Rigidbody2D myRigidBody2D;

    private Rigidbody2D myRB;
    // Start is called before the first frame update

    private void OnEnable()
    {
        var controls= new Controls();
        controls.Enable();
        controls.Main.Move.performed += MoveOnperformed;
        controls.Main.Move.canceled += OnMoveCanceled;
        controls.Main.Jump.performed += JumpOnPerformed;
    }

    private void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        if (isOnGround)
        {
            myRigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
{
     direction = Vector2.zero;
}
    private void MoveOnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var myRigidBody2D = GetComponent<Rigidbody2D>();
        direction.y = 0;
        //myRigidBody.MovePosition(direction);
        //myRigidBody.velocity = direction;
       

        myRigidBody2D.AddForce(direction * jumpForce);
    }
    
}