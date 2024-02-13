using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple1 myApple1 = new Apple1();

        myApple1.SayHello();
        myApple1.Chop();

        Fruit1 myFruit1 = new Apple1();
        myFruit1.SayHello();
        myFruit1.Chop();
    }
}
