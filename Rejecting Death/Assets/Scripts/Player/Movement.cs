using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    public bool isGrounded;

    private Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(playerRigidbody != null)
        {
            ApplyInput();
        }
        else
        {
            Debug.LogWarning("Rigid body not attached to player " + gameObject.name);
        }
        float h = Input.GetAxis("Horizontal");

        bool player_jump = Input.GetButtonDown("Jump");

        if (player_jump && isGrounded)
        {
            
        }
    }

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * moveSpeed * Time.deltaTime;

        Vector2 force = new Vector2(xForce, 0);

        playerRigidbody.AddForce(force);

        Debug.Log(xForce);
        Debug.Log(playerRigidbody.velocity);
    }
}
