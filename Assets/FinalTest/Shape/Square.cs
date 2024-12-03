using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;
    private void Start()
    {
        Init("Square");
        CalculateArea();
        Resize();
        Draw();

    }
    public override float CalculateArea()
    {
        side = 5;
        side = side * side;
        Debug.Log($"Square{side}");
        return side;
    }
    public override void Resize()
    { Debug.Log("has been going to be changing on Square"); }


}
