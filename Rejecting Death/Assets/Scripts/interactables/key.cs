using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public Transform folowTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, folowTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("Player"))
        {
            if (isFollowing)
            {
                CharacterController thePlayer = FindObjectOfType<CharacterController>();

                folowTarget = thePlayer.transform;
            }
        }
    }
}
