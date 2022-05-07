using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Isınlanma : MonoBehaviour
{
    public GameObject text;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player" && Input.GetKeyDown("x"))
        {
          Player.transform.position = new Vector3(3.36f, -1.7f, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        text.SetActive(true);
    }

     void OnTriggerExit2D(Collider2D other)
    {
        text.SetActive(false);
    }
}
