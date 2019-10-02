using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour
{
    public int miningSpeed = 1;
    public int bronzeSupply = 0;
    public int silverSupply = 0;
    public int goldSupply = 0;
    public int bronzeMined = 0;
    public int silverMined = 0;
    public int goldMined = 0;
    public int xPos = 0;
    public int yPos = 0;
    public GameObject cubeRed;
    public GameObject cubeWhite;
    public GameObject cubeYellow;
    public Vector3 position = new Vector3 (0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        print("You have mined " + bronzeMined + " bronze, " + silverMined + " silver, and " + goldMined + " gold.");
        xPos = -11;
        yPos = 5;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > miningSpeed)
        {
            position = new Vector3(xPos, yPos, 0);
            if (silverSupply == 0 && goldSupply > 0)
            {
                goldMined++;
                goldSupply--;
                Instantiate(cubeYellow, position, Quaternion.identity);
                xPos += 2;
            }
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
            if (bronzeMined < 4)
            {
                bronzeSupply++;
            }
            if (bronzeMined > 4)
            {
                silverSupply++;
            }
            if (bronzeMined == 2 && silverMined == 2)
            {
                goldSupply++;
            }
            if (xPos > 11)
            {
                yPos -= 2;
                xPos = -11;
            }
            print("You have mined " + bronzeMined + " bronze, " + silverMined + " silver, and " + goldMined + " gold.");
            miningSpeed++;

        }
    }
}
