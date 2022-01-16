using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float ms;
    public float jumpForce;
    public LayerMask ground;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        float horiz = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horiz*ms, rb.velocity.y);

        if(horiz > 0 || horiz <0)
        {
            transform.localScale = new Vector2(1 * horiz, 1);
        }

        if(Input.GetKey(KeyCode.Space))
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
            ScoreManager.instance.AddPoint();
            Debug.Log("Lewat");
        }    

        if(collision.gameObject.tag=="obs"){
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }

        if(collision.gameObject.tag=="mush"){
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }

        
    }
    
}
