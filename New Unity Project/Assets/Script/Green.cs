using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
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
                   DumanOyunu.memory1 = 2;
                }

                 else if(DumanOyunu.memory2 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory2 = 2;
                }

                 else if(DumanOyunu.memory3 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory3 = 2;
                }

                else if(DumanOyunu.memory4 == 0 && Input.GetKeyDown("x"))
                {
                   bip.Play();
                   DumanOyunu.memory4 = 2;
             
                }

           }
    }
}
