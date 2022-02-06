using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // inheritance, for some reason dog is eating 10x portion :)
    public override void Feed()
    {
        Feed(10);
    }

    // inheritance
    public override void Act()
    {
        Debug.Log("*bark bark*");
    }
}
