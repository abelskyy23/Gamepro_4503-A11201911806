using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float ms;
    public float jumpForce;
    public LayerMask ground;
    float score;

    public Text scoreTxt;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = ""+score;
        
        float horiz = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horiz*ms, rb.velocity.y);

        if(horiz > 0 || horiz <0)
        {
            transform.localScale = new Vector2(1 * horiz, 1);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, ground);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag=="point"){
            score= score+1;
            Debug.Log("Lewat");
        }    

        if(collision.gameObject.tag=="obs"){
            Destroy(gameObject);

        }
        
    }
    
}
