using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    /// Action map for input. This variable is not currently necessary
    [SerializeField]
    PlayerInput currentMap;

    /// Components
    Rigidbody rigidBody;
    Animator animator;

    /// Movement
    // These are the inputs from the action map
    float moveController;                       // Gets the input from the gamepad L and R triggers
    Vector2 inputMoveKeyboard;                  // Gets the input from the keyboard W and S buttons     Both of these are for forward/backward movement
    Vector2 inputRotate;                        // Gets the input from the keyboard A and D, and gamepad left joystick, as both are Vector2
    float holdHandbrake;                        // Gets the input from the keyboard left shift, and the gamepad R shoulder button, determines if player can handbrake
    Vector3 moveDirection;                      // This is the vector in which the movement is calculated before being given to player

    [Header("Movement")]
    // Public
    public float playerAccelerationSpeed;       // Speed at which the player accelerates
    public float playerSpeed;                   // Speed at which the player moves ---> this isn't used anymore, the acceleration seemed to work fine
    public float playerMaxSpeed;                // Max speed we want the player to move. If it exceeds this value, a force is added against the player to counteract
    public float rotationSpeed;                 // Speed at which the player can rotate. This is increased if handbrake is held
    public float jumpForce;                     // Force to add to player when they jump
    // Private
    float maxSquareVelocity;                    // Squared velocity of our playerMaxSpeed to check against rigidbody's squared velocity. Faster calculation
    float currentRotationSpeed;                 // Current rotation speed, the value changed if handbrake is held
    bool isMoving;                              // Check if moving, then you can rotate
    bool isGrounded;                            // Check if on ground

    // Animation
    float idleOrRun;                            // Blend tree value to move from idle anim to running anim
    float runningSpeed;                         // Value to speed up the animation for running depending on our actual speed

    // Gameplay
    public List<Powerups> currentPowerup;
    public Transform placeToRespawn;
    public bool hasJump;
    int speedToAdd;
    float removePowerupTimer = 1.0f;
    bool reduceSpeed = true;
    bool respawning = false;

    // UI
    public Canvas gameUI;
    public Canvas pauseUI;
    public Image currentPowerupImage;
    public TMP_Text speedText;
    [SerializeField]
    Sprite[] powerupSprites;
    public bool cycleSprites;
    int sprites;
    int cycleCount = 0;
    float spriteTimer = 0.1f;

    // Audio
    bool fadeout;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        maxSquareVelocity = playerMaxSpeed * playerMaxSpeed;
        speedText.text = "Speed: " + playerMaxSpeed;
        pauseUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Grounded: " + isGrounded);
        Rotate();
        CyclePowerup();
    }

    void FixedUpdate()
    {
        Move();
    }

    void LateUpdate()
    {
        UpdateAnimation();
    }

    void OnForwardKeyboard(InputValue _value)
    {
        inputMoveKeyboard = _value.Get<Vector2>();
    }

    void OnRotateKeyboard(InputValue _value)
    {
        inputRotate = _value.Get<Vector2>();
    }

    void OnForwardController(InputValue _value)
    {
        moveController = _value.Get<float>();
    }

    void OnBackwardController(InputValue _value)
    {
        moveController = -_value.Get<float>();
    }

    void OnRotateController(InputValue _value)
    {
        inputRotate = _value.Get<Vector2>();
    }

    void OnJump(InputValue _value)
    {
        Jump();
    }

    void OnHandbrake(InputValue _value)
    {
        holdHandbrake = _value.Get<float>();
    }

    void OnRespawn(InputValue _value)
    {
        Respawn();
    }

    void OnPause(InputValue _value)
    {
        PauseState();
    }

    public void PauseState()
    {
        Time.timeScale = Time.timeScale == 1.0f ? 0.0f : 1.0f;

        pauseUI.enabled = Time.timeScale == 1.0f ? false : true;
        gameUI.enabled = !pauseUI.enabled;
    }

    void Move()
    {
        if (rigidBody.velocity.magnitude <= 0.05f)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }

        if (inputMoveKeyboard.y != 0 || moveController != 0 && isGrounded)
        {
            GetComponent<AudioSource>().volume = 0.1f;

            if (!GetComponent<AudioSource>().isPlaying)
            {
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            if (GetComponent<AudioSource>().volume > 0)
            {
                GetComponent<AudioSource>().volume -= 0.001f;
                if (GetComponent<AudioSource>().volume <= 0)
                {
                    GetComponent<AudioSource>().Stop();
                }
            }
        }

        if (currentMap.currentControlScheme == "Keyboard Controls")
        {
            moveDirection = transform.forward * inputMoveKeyboard.y;
        }
        else if (currentMap.currentControlScheme == "Gamepad Controls")
        {
            moveDirection = transform.forward * moveController;
        }

        if (respawning == false)
        {
            if (Mathf.Abs(rigidBody.velocity.sqrMagnitude) > maxSquareVelocity)
            {
                rigidBody.AddForce(-rigidBody.velocity / (rigidBody.velocity.sqrMagnitude - maxSquareVelocity));
                //rigidBody.velocity = rigidBody.velocity.normalized * playerMaxSpeed;
                // rigidBody.AddForce(moveDirection * playerSpeed * Time.deltaTime);
            }
            else if (Mathf.Abs(rigidBody.velocity.magnitude) < playerMaxSpeed)
            {
                Debug.Log("Wtf");
                rigidBody.AddForce(moveDirection * playerAccelerationSpeed * Time.deltaTime, ForceMode.Acceleration);
            }
            // rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, playerMaxSpeed);
        }
    }

    void Jump()
    {
        if (isGrounded && currentPowerup.Count != 0)
        {
            if (currentPowerup[0].powerType == PowerType.JUMP)
            {
                rigidBody.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);

                currentPowerup.RemoveAt(0);
                hasJump = false;
            }
        }
    }

    void Rotate()
    {
        //transform.Rotate(new Vector3(0, inputRotate.x * rotationSpeed * Time.deltaTime, 0));
        currentRotationSpeed = holdHandbrake == 0 ? rotationSpeed : rotationSpeed * 2.5f;

        if (inputRotate.x != 0)
        {
            if (isMoving || !isGrounded)
            {
                rigidBody.MoveRotation(rigidBody.rotation * new Quaternion(0, inputRotate.x * currentRotationSpeed * Time.deltaTime, 0, 1));
            }
        }
        else
        {
            if (isMoving || !isGrounded)
            {
                rigidBody.MoveRotation(rigidBody.rotation * new Quaternion(0, inputRotate.x * currentRotationSpeed * Time.deltaTime, 0, 1));
                //rigidBody.rotation = Quaternion.RotateTowards(rigidBody.rotation, toRotation, rotationSpeed * 50 * Time.deltaTime);
            }
        }
    }

    void UpdateAnimation()
    {
        if (isMoving)
        {
        //    animator.SetBool("isRunning", true);
        }
        else
        {
        //    animator.SetBool("isRunning", false);
        }

        if (isGrounded)
        {
            idleOrRun = Mathf.Clamp(rigidBody.velocity.magnitude, 0, 1);

            animator.SetFloat("idleOrRun", idleOrRun);
        }
        runningSpeed = 1 + rigidBody.velocity.magnitude / 10;

        animator.speed = runningSpeed;
    }

    public void CyclePowerup()
    {
        int lastIndex = currentPowerup.Count - 1;

        if (cycleSprites)
        {
            currentPowerupImage.color = new Vector4(1, 1, 1, 1);

            spriteTimer -= Time.deltaTime;
            if (spriteTimer <= 0.0f)
            {
                spriteTimer = 0.1f;
                sprites += 1;

                if (sprites > 2)
                {
                    sprites = 0;
                    cycleCount += 1;

                    if (cycleCount >= 6)
                    {
                        cycleCount = 0;
                        sprites = 0;
                        cycleSprites = false;


                        switch(currentPowerup[lastIndex].powerType)
                        {
                            case PowerType.SPEEDUP:
                                speedToAdd = 5;
                                HandleSpeedChanges(true);
                                break;
                            case PowerType.SPEEDDOWN:
                                speedToAdd = -2;
                                HandleSpeedChanges(true);
                                break;
                        }
                    }
                }
            }
        }

        currentPowerupImage.sprite = powerupSprites[sprites];
        
        if (cycleSprites == false && currentPowerup.Count > 0)
        {
            if (currentPowerup[lastIndex].powerType == PowerType.SPEEDUP)
            {
                sprites = 0;

                removePowerupTimer -= Time.deltaTime;
                if (removePowerupTimer <= 0)
                {
                    currentPowerup.RemoveAt(lastIndex);
                    removePowerupTimer = 1.0f;
                }
            }
            else if (currentPowerup[0].powerType == PowerType.JUMP)
            {
                sprites = 1;
            }
            else if (currentPowerup[lastIndex].powerType == PowerType.SPEEDDOWN)
            {
                sprites = 2;
                removePowerupTimer -= Time.deltaTime;
                if (removePowerupTimer <= 0)
                {
                    currentPowerup.RemoveAt(lastIndex);
                    removePowerupTimer = 1.0f;
                }
            }
        }
        
        if (cycleSprites == false && currentPowerup.Count == 0)
        {
            currentPowerupImage.color = new Vector4(1, 1, 1, 0);
        }
    }

    void HandleSpeedChanges(bool _addOrRemove)
    {
        if (_addOrRemove == true)
        {
            playerMaxSpeed += speedToAdd;
        }
        else
        {
            if (reduceSpeed)
            {
                playerMaxSpeed /= 2;
                reduceSpeed = false;
                StartCoroutine(SetReduceSpeedBackToTrue());
            }
        }

        //playerMaxSpeed = Mathf.Round(playerMaxSpeed);
        playerMaxSpeed = Mathf.Ceil(playerMaxSpeed);

        if (playerMaxSpeed < 2)
        {
            playerMaxSpeed = 2.0f;
        }

        maxSquareVelocity = playerMaxSpeed * playerMaxSpeed;
        speedText.text = "Speed: " + playerMaxSpeed;
    }

    public bool CheckForJumps()
    {
        for (int i = 0; i < currentPowerup.Count; i++)
        {
            if (currentPowerup[i].powerType == PowerType.JUMP)
            {
                return hasJump = true;
            }
        }
        return hasJump = false;
    }

    public void Respawn()
    {
        respawning = true;
        Debug.Log("Hello");
        transform.position = placeToRespawn.position;
        transform.rotation = placeToRespawn.localRotation;

        rigidBody.velocity = Vector3.zero;

        HandleSpeedChanges(false);
    }
    

    IEnumerator SetReduceSpeedBackToTrue()
    {
        if (reduceSpeed == false)
        {
            yield return new WaitForSeconds(0.5f);

            reduceSpeed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GroundComponent>())
        {
            isGrounded = true;
            respawning = false;
        }

        if (other.GetComponent<HazardComponent>())
        {
            //HandleSpeedChanges(false);

            //if (reduceSpeed)
            //{
            //    playerMaxSpeed = playerMaxSpeed / 2;
            //    maxSquareVelocity = playerMaxSpeed * playerMaxSpeed;

            //    speedText.text = "Speed: " + playerMaxSpeed;
            //    reduceSpeed = false;

            //    StartCoroutine(SetReduceSpeedBackToTrue());
            //}
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<GroundComponent>())
        {
            isGrounded = false;
        }
        if (other.gameObject.GetComponent<HazardComponent>())
        {
            Respawn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HazardComponent>())
        {
            Respawn();
        }
    }
}
