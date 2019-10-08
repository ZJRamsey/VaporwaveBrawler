using UnityEngine;
using System.Collections;

public class GenericFighter: MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        //Set up values
        
    }
    
    void React (Vector3 direction, float power, int moveType)
    {
        //1: Push back
        //2: Straight up launch
        
        //moveType is the style of move the player is being hit by
        //Different moves trigger different paths
        //Take the direction to decide whether to launch left or right
        //Multiply by power from enemy damage
    }
    
    // Update is called once per frame
    void Update ()
    {
        //Movement input
        //Move character
        //Button input
        //Perform moves
        //
    }
}