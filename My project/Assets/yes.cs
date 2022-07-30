using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    string Heroname = " Mario ";
    int Heroheight = 180;
    int Heroage = 24;
    string herosuperpower = "flame";
    string enemyname="supermario ";
    int enemyheight = 170;
    int enemyage=23;
    string enemysuperpower = "ice";

    // Start is called before the first frame update
    void Start()
    {
        print("the heros name is" + Heroname + "and his height is" + Heroheight);
        print("The heros age is" + Heroage + "and his superpower is " + herosuperpower);
        print("The enemys name is" + enemyname + "and his height is " + enemyheight);
        print("The enemys age is " + enemyage + "and his superpower is " + enemysuperpower);
    }

}