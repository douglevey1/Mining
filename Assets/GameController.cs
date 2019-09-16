using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float s;
    Boolean ok = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        s = Time.time;
        if (s > 3 && ok == false)
        {
            print("Three seconds have passed...");
            ok = true;
        }
    }
}
