﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneGecis : MonoBehaviour
{


  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void StartGame()
    {
        SceneManager.LoadScene("LevelMenu");
    }

     public void Level1()
    {
      SceneManager.LoadScene("Level1");  
    }

    public void Level2()
    {
      SceneManager.LoadScene("Level2");  
    }

     public void Level3()
    {
      SceneManager.LoadScene("Level3");  
    }

     public void Level4()
    {
      SceneManager.LoadScene("Level4");  
    }

     public void Level5()
    {
      SceneManager.LoadScene("Level5");  
    }

     public void Level6()
    {
      SceneManager.LoadScene("Level6");  
    }



    public void Son()
    {
        SceneManager.LoadScene("Son");
    }

}
