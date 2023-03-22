using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour
{
    private bool isRolling = false;

    //Movement
    private float speed = 6.0f;
    private float maxSpeed = 15.0f;
    private float jumpForce = 7.0f;
    private float gravity = 15.0f;
    private float sideSpeed = 15.0f;
    private float speedMultip = 0.0005f;
    private float TURN_SPEED = 0.05f;

    //Animation
    public Animator animator;

    private CharacterController controller;
    private readonly int LANE_DISTANCE = 1;
    private int lane = 2;
    private float verticalVelocity = 0;

    private bool isGameStarted = false;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        speed = 6.0f;
        speedMultip = 0.0005f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            isGameStarted = true;
            FindObjectOfType<GameManager>().StartGame();
        }

        if (!isGameStarted)
            return;

        if (speed < maxSpeed)
            speed += speedMultip;
        
        //Reading inputs
        if (Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.LeftArrow))
            SwitchLane(false);
        if (Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.RightArrow))
            SwitchLane(true);

        //Calculate where it should be in the future
        Vector3 targetPosition = transform.position.z * Vector3.forward;
        if (lane == 1)
            targetPosition += Vector3.left * LANE_DISTANCE;
        else if (lane == 3)
            targetPosition += Vector3.right * LANE_DISTANCE;

        //Calculate move
        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * sideSpeed;

        bool isGrounded = IsGrounded();
            animator.SetBool("Grounded", isGrounded);

        //Calculate Y
        if (isGrounded)
        {
            verticalVelocity = -0.1f;

            if (Input.GetKeyDown(KeyCode.W) ||
                Input.GetKeyDown(KeyCode.UpArrow) ||
                Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
                verticalVelocity = jumpForce;
                FindObjectOfType<GeralSFX>().PlaySFX(2);
            }
        }
        else {
            verticalVelocity -= (gravity * Time.deltaTime);

            //Fast falling
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.DownArrow)){
                verticalVelocity = -jumpForce;
            }
        }

        if ((Input.GetKeyDown(KeyCode.S) ||
             Input.GetKeyDown(KeyCode.DownArrow)) &&
            !isRolling)
        {
            StartRoll();
            Invoke(nameof(EndRoll), 1.0f);
        }

        moveVector.y = verticalVelocity;
        moveVector.z = speed;

        //Move
        controller.Move(moveVector * Time.deltaTime);

        //Rotate where going
        Vector3 direction = controller.velocity;
        if (direction != Vector3.zero) {
            direction.y = 0;
            transform.forward = Vector3.Lerp(transform.forward, direction, TURN_SPEED);
        }

    }

    private void SwitchLane(bool goingRight)
    {
        lane += goingRight ? 1 : -1;
        lane = Mathf.Clamp(lane, 1, 3);
    }

    private bool IsGrounded() { 
        Ray groundRay = new( new Vector3(
                controller.bounds.center.x,
                (controller.bounds.center.y - controller.bounds.extents.y) + 0.2f,
                controller.bounds.center.z),
            Vector3.down);

        return Physics.Raycast(groundRay, 0.2f + 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            animator.SetTrigger("Dead");
            isGameStarted = false;
            FindObjectOfType<GeralSFX>().PlaySFX(3);
            FindObjectOfType<GameManager>().DeathScreen();
        }
    }

    private void StartRoll() {
        isRolling = true;
        animator.SetBool("Roll", true);
        controller.height /= 2;
        controller.center = new(controller.center.x, controller.center.y / 2, controller.center.z);
    }

    private void EndRoll() {
        animator.SetBool("Roll", false);
        controller.height *= 2;
        controller.center = new(controller.center.x, controller.center.y * 2, controller.center.z);
        isRolling = false;
    }
}
