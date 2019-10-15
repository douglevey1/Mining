using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Ore myOre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown ()
    {
        Destroy(gameObject);
        if(myOre == Ore.Bronze)
        {
            GameController.bronze--;
            GameController.score += GameController.bronzePoints;
        }
        else if (myOre == Ore.Silver)
        {
            GameController.silver--;
           GameController.score += GameController.silverPoints;
        }
        if (myOre == Ore.Gold)
        {
            GameController.gold--;
            GameController.score += GameController.goldPoints;
        }
    }
}
