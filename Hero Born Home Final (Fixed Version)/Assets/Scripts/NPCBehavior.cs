using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    //Method checks to see whether player is within range, if true, the following text appears in console
   void OnTriggerEnter(Collider other)
   {
        if(other.name == "Player")
        {
            //This dialogue serves to guide the player in this first elvel
            Debug.Log("Welcome to Hero Born, Player!");
            Debug.Log("This first level will serve as a hub to get you familiar with the controls.");
            Debug.Log("You can use the W, A, S, and D keys to move and turn your camera around!");
            Debug.Log("Pressing the Space bar will allow you to jump! You have no limit to how many times you can jump so feel free to bounce around!");
            Debug.Log("To access the first level, collect the health pick up and step on the goal pad next to me!");
        }
   }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            //checks and prints if the player leaves the NPC's range
            Debug.Log("Player out of range.");
        }
    }
}
