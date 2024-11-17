using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public const float speed = 0.3f,maximumSteps=80;

    int steps = 0,pointer=0;
    List<Tuple<float, float>> coordinates = new List<Tuple<float, float>>
    {
        (new Tuple<float, float>(speed, 0)),
        (new Tuple<float, float>(0, speed)),
        (new Tuple<float, float>(-speed, 0)),
        (new Tuple<float, float>(0, -speed)),
    };
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //print("the start method has been called");// called once
        


    }

    // Update is called once per frame
    void Update()
    {
        //print("the update method has been called");// called over and over
        steps++;
        if (steps >= maximumSteps)
        {
            steps = 0;
            pointer++;
            if(pointer > 3)
            {
                pointer = 0;
            }

        }
        transform.Translate(coordinates[pointer].Item1, 0, coordinates[pointer].Item2);
    }
    
}
