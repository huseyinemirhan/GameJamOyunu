using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyeYoneticisi : MonoBehaviour
{
    public Button seviye1_button,seviye2_button,seviye3_button,seviye4_button,seviye5_button,seviye6_button,seviyeson_button;

    public static bool seviye1,seviye2,seviye3,seviye4,seviye5,seviye6,sonopened;

    // Start is called before the first frame update
    void Start()
    {
        seviye1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(seviye2 == true)
        {
           seviye2_button.interactable = true;
        }

          if(seviye3 == true)
        {
           seviye3_button.interactable = true;
        }

           if(sonopened == true)
        {
           seviyeson_button.gameObject.SetActive(true);
           seviyeson_button.interactable = true;
        }

    }
}
