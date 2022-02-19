using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesmerize
{

}

public interface IEntity 
{
    /*
     We have an iterface awith attack and health information in it.
     We may not always need health and attack information at the same time.
     If we write them all together, we will be calling information that we do not need. 
     So we have to divide this information into different interfaces.
     */

    void MeMesmerize(IEntity ownerEntity);

    int STR { get; }
    int STA { get; }
    int COS { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }

    float Health { get; set; }
    int MaxHealth { get; }
    int ModifyHealth(int amount);
    
}

public class Door : IHealth
{

    public float Health { get; set; } = 100;
    public int MaxHealth { get; } = 250;
    public int ModifyHealth(int amount)
    {
       return (int)(Health -= amount);
    }
}


public interface IHealth
{
    public float Health { get; set; }
    public int MaxHealth { get; }
    public int ModifyHealth(int amount);
}

public interface IAttack
{
    int STR { get; }
    int STA { get; }
    int COS { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }
}
