using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : Spell
{
    private void Start()
    {
        Cast();
        Cast("Ice");
    }
    public override void Cast() { Debug.Log($"icel"); }

}
