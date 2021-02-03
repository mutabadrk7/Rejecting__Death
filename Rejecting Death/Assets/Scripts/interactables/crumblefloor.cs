using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumblefloor : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float fallDelay;
    public float respawnDelay;
    private Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        startPos = new Vector2(transform.position.x, transform.position.y);
        GetComponent<EdgeCollider2D>().isTrigger = false;
    }

    // Update is called once per frame
     void Update()
    {
        //if(GetComponent<EdgeCollider2D>().isTrigger = true)
           
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }    
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb2d.isKinematic = false;
        GetComponent<EdgeCollider2D>().isTrigger = true;
        
        yield return 0;
    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnDelay);
        StartCoroutine(Respawn());
        rb2d.isKinematic = false;
        transform.position = startPos;
        
        GetComponent<EdgeCollider2D>().isTrigger = false;
        yield return 0;
    }
}