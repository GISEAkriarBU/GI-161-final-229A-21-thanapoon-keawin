using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : Spell
{
    private void Start()
    {
        Cast();
        Cast("Earth");
        Cast("Monolith ", 20);
    }

    public override void Cast() { Debug.Log($"Earthl") ; }
}
