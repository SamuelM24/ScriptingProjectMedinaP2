// Player Script
using UnityEngine;

public class Player : MonoBehaviour
{
    private int experience;

    public int Experience
    {
        get
        {
            Debug.Log("Player's experience retrieved: " + experience);
            return experience;
        }
        set
        {
            Debug.Log("Player's experience set to: " + value);
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            int level = experience / 1000;
            Debug.Log("Player's level calculated: " + level);
            return level;
        }
        set
        {
            Debug.Log("Player's level set to: " + value);
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}
