using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Not : MonoBehaviour
{

      public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
