using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float MovementSpeed;
  public float JumpForce;
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

        if(Input.GetKeyDown("up") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
        }

        if(!Mathf.Approximately(0,movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        }
    }
}
