using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Analytics;

public class hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       Analytics.SendEvent("GameStart", 1);
       
        

    }
}