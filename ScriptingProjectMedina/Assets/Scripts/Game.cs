// Game Script
using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Experience = 5;
        int x = myPlayer.Experience;

        Debug.Log("Player's level: " + myPlayer.Level);
    }
}
