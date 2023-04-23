using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 20f;
    private CharacterController myCC;

    public Animator camAnim;
    private bool isWalking;

    private Vector3 inputVector;
    private Vector3 movementVector;
    private float myGravity = -10f;

    static public int healthPl = 3;

    // Start is called before the first frame update
    void Start()
    {
        myCC = GetComponent<CharacterController>();
        healthPl = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPl == 0)
        {
            Debug.Log("0");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        GetInput();
        MovePlayer();
        checkedForHeadBob();

        camAnim.SetBool("isWalking", isWalking);

    }
    
    void GetInput() {
        inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        inputVector.Normalize();
        inputVector = transform.TransformDirection(inputVector);

        movementVector = (inputVector * playerSpeed) + (Vector3.up * myGravity);
    }
    
    void MovePlayer() {
        myCC.Move(movementVector * Time.deltaTime);
    }

    void checkedForHeadBob() {
        if (myCC.velocity.magnitude > 0.1f) {
            isWalking = true;
        } else {
            isWalking = false;
        }
    }
        public void OnCollisionEnter(Collision other)
        {
            print("12");
            if (other.gameObject.tag == "Finish")
            {
                print("11");
                SceneManager.LoadScene(0);
            }
        }
}
