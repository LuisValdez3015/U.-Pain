using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
public class bye : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Analytics.SendEvent("LevelComplete", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
