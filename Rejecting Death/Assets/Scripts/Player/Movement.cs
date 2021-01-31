using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    public bool isGrounded;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");

        bool player_jump = Input.GetButtonDown("Jump");

        if (player_jump && isGrounded)
        {
            
        }
    }
}
