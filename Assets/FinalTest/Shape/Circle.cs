using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float radius;
    private void Start()
    {
        radius = 3.14f;
        Init("Circle");
        CalculateArea();
        Resize();
        Draw();
    }
    public override float CalculateArea()
    {

        float circularRange = 20;
 
        radius = radius * circularRange * circularRange;
        
        Debug.Log($"circular{radius}way");
        return radius;
        

    }
    public override void Resize()
    { Debug.Log("has been going to be changing on circular"); }

    
}
