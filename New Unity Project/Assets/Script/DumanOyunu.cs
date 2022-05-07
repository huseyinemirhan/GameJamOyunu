using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumanOyunu : MonoBehaviour
{
    public static int memory1,memory2,memory3,memory4;
    public int memory1g,memory2g,memory3g,memory4g;
    public static bool isOpened;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        memory1g = memory1;
        memory2g = memory2;
        memory3g = memory3;
         memory4g = memory4;


         if (memory1 == 1 && memory2 == 2 && memory3 == 2 && memory4 == 1)
         {
             isOpened = true;
         }

    }
    }

    