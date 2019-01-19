using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float gravity = -12;
    public float jumpheight = 1;
    [Range(0,1)]
    public float airControlPercent;

    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity;
    float currentSpeed;
    float velocityY;

    [SerializeField] Transform cameraTrans;

    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update () {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = input.normalized;
        bool running = Input.GetKey(KeyCode.LeftShift);

        Move(inputDir, running);

        if(Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

	}

    void Move(Vector2 inputDir, bool running)
    {

        if (inputDir != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraTrans.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, GetModifiedSmoothTime(turnSmoothTime));
        }
        
        float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, GetModifiedSmoothTime(speedSmoothTime));

        velocityY += Time.deltaTime * gravity;

        Vector3 velocity = transform.forward * currentSpeed + Vector3.up * velocityY;


        controller.Move(velocity * Time.deltaTime);

        if (controller.isGrounded)
        {
            velocityY = 0;
        }
    }


    void Jump()
    {
        if(controller.isGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(-2 * gravity * jumpheight);
            velocityY = jumpheight;
        }
    }

    float GetModifiedSmoothTime(float smoothTime)
    {
        if(controller.isGrounded)
        {
            return smoothTime;
        }
        if(airControlPercent == 0)
        {
            return float.MaxValue;
        }

        return smoothTime / airControlPercent;
    }
}
