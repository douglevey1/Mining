using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour
{
    public int miningSpeed = 3;
    public int timeToMine = 3;
    public static int bronzePoints = 1;
    public static int silverPoints = 10;
    public static int goldPoints = 100;
    public static int score = 0;
    public static int bronze = 0;
    public static int silver = 0;
    public static int gold = 0;
    public int xPos = 0;
    public int yPos = 0;
    Ore lastCube = Ore.Bronze;
    public GameObject cubePrefab;
    public GameObject myCube;
    public Vector3 position = new Vector3 (0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        xPos = -11;
        yPos = 5;
    }
    //Spawns a cube in a specified color
    public void SpawnCube(Ore oreType)
    {
        Color cubeColor = Color.red;
        if(oreType == Ore.Bronze)
        {
            cubeColor = Color.red;
            bronze++;
        }
        else if(oreType == Ore.Silver)
        {
            cubeColor = Color.white;
            silver++;
        }
        else if(oreType == Ore.Gold)
        {
            cubeColor = Color.yellow;
            gold++;
        }
        position = new Vector3(xPos, yPos, 0);
        myCube = Instantiate(cubePrefab, position, Quaternion.identity);
        myCube.GetComponent<Renderer>().material.color = cubeColor;
        myCube.GetComponent<CubeController>().myOre = oreType;
        xPos += 2;
        lastCube = oreType;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToMine)
        {
             if (bronze == 2 && silver == 2 && lastCube != Ore.Gold)
            {
                SpawnCube(Ore.Gold);
            }
            else if (bronze < 4)
            {
                SpawnCube(Ore.Bronze);
            }
            else
            {
                SpawnCube(Ore.Silver);
            }
            //Checks to see if the next cube spawned would be off screen, and if so, sets the position 2 units under the previous leftmost x position
            if (xPos > 11)
            {
                yPos -= 2;
                xPos = -11;
            }
            timeToMine += miningSpeed;
            print("Score: " + score);
        }
    }
}
