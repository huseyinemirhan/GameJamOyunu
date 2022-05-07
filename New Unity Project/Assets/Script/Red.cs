using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Red : MonoBehaviour
{
     public GameObject Tutorial;
     public AudioSource bip;

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
   
             if(col.gameObject.tag == "Player")
             {
                if(DumanOyunu.memory1 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory1 = 1;
                }

                 else if(DumanOyunu.memory2 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory2 = 1;
                }
               

                 else if(DumanOyunu.memory3 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory3 = 1;
                }

                else if(DumanOyunu.memory4 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory4 = 1;
             
                }

           }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
             {
         Tutorial.SetActive(true);
             }
    }

    void OnTriggerExit2D(Collider2D col)
    {
          if(col.gameObject.tag == "Player")
             {
         Tutorial.SetActive(false);
             }
    }

}