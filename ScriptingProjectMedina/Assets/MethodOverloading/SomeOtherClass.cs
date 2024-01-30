using System.Collections;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}
