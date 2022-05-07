using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void seviye1bitir()
    {
        SeviyeYoneticisi.seviye2 = true;
       SceneManager.LoadScene("LevelMenu");
    }

     public static  void seviye2bitir()
    {
        SeviyeYoneticisi.seviye3 = true;
         SceneManager.LoadScene("LevelMenu");
    }

      public static void seviye3bitir()
    {
      SeviyeYoneticisi.sonopened = true;
         SceneManager.LoadScene("LevelMenu");
    }

       public static void seviyesonbitir()
    {
         SceneManager.LoadScene("LevelMenu");
    }
}
