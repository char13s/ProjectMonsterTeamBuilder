using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    float health;
    float attack;
    float defense;
    float damageReduction;
    float evasion;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public abstract void Passive();
    public abstract void SuperEffect();
    public abstract void Super();
}
