using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timePassed = 0;
    int miningSpeed = 3;
    int bronzeSupply = 3;
    int silverSupply = 2;
    int bronzeMined = 0;
    int silverMined = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("You have mined " + bronzeMined + " bronze and " + silverMined + " silver.");
    }
    // Update is called once per frame
    void Update()
    {
        timePassed = Time.time;
        if (timePassed > miningSpeed)
        {
            if (bronzeSupply == 0 && silverSupply > 0)
            {
                silverMined++;
                silverSupply--;
            }
            if (bronzeSupply > 0)
            {
                bronzeMined++;
                bronzeSupply--;
            }
            print("You have mined " + bronzeMined + " bronze and " + silverMined + " silver.");
            miningSpeed += 3;
        }
    }
}
