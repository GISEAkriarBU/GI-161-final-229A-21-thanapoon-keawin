using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : Spell
{
    private void Start()
    {
        Cast();
        Cast("fire");
    }
    public override void Cast(){ Debug.Log($"firel"); }
}
