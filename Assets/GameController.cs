using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour
{
    public int miningSpeed = 3;
    public int bronzeSupply = 3;
    public int silverSupply = 2;
    public int bronzeMined = 0;
    public int silverMined = 0;
    public int xPos = 0;
    public GameObject cubeRed;
    public GameObject cubeWhite;
    public Vector3 position = new Vector3 (0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        print("You have mined " + bronzeMined + " bronze and " + silverMined + " silver.");
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > miningSpeed)
        {
            position = new Vector3(xPos, 0, 0);
            if (bronzeSupply == 0 && silverSupply > 0)
            {
                silverMined++;
                silverSupply--;
                Instantiate(cubeWhite, position, Quaternion.identity);
                xPos += 2;
            }
            if (bronzeSupply > 0)
            {
                bronzeMined++;
                bronzeSupply--;
                
                Instantiate(cubeRed, position, Quaternion.identity);
                xPos += 2;
            }
            print("You have mined " + bronzeMined + " bronze and " + silverMined + " silver.");
            miningSpeed += 3;
        }
    }
}
