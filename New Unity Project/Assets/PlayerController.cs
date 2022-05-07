using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float MovementSpeed;
  public float JumpForce;
  public Animator animator;
  private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position  += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        animator.SetFloat("Speed", movement);

        if(Input.GetKeyDown("up") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
        }
    }
}
