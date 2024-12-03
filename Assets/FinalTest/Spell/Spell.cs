using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast() { Debug.Log($"spell"); }

    public void Cast(string nameofspell) { Debug.Log($"{nameofspell} " ) ; } 
    public void Cast(string typeofspell, int manaUsing) { Debug.Log($"{typeofspell} is using { manaUsing}"); }

}
