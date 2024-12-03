using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    public void Init(string newShapename) 
    { newShapename = shapeName; }
    public abstract float CalculateArea();
    public virtual void Resize() 
    { Debug.Log("has been going to be resize"); }
    public void Draw()
    { Debug.Log($"has been going to draw {shapeName}"); }

}
