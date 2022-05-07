using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public GameObject Tutorial2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     

 void OnTriggerStay2D(Collider2D col)
         {

       if(col.gameObject.tag == "Player" && Input.GetKeyDown("x"))
       {
           DumanOyunu.memory1 = 0;
            DumanOyunu.memory2 = 0;
             DumanOyunu.memory3 = 0;
              DumanOyunu.memory4 = 0;
       }







         }


  void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
             {
         Tutorial2.SetActive(true);
             }
    }

    void OnTriggerExit2D(Collider2D col)
    {
          if(col.gameObject.tag == "Player")
             {
         Tutorial2.SetActive(false);
             }
    }






}
