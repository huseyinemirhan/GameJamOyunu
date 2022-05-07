using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarkToplama : MonoBehaviour
{
    public static int ToplananCark = 0;
    public int ToplananCarks = 0;
    public GameObject bitirme;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        ToplananCarks = ToplananCark;
    }

    // Update is called once per frame
    void Update()
    {
      if(ToplananCark == 3)
      {
        bitirme.SetActive(true);
        anim.SetBool("isCompleted", true);
      }  
    }
}
