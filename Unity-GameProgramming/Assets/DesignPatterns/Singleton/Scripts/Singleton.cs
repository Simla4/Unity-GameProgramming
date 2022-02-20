using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    public static Singleton instance;

    public static Singleton Instance => instance ?? (instance = new Singleton());
                    // both the same   
    /*public static MonoSingleton Instance
    {
        get => instance ?? (instance = new MonoSingleton());
                    // both the same            
        get
        {
            if (instance == null)
            {
                instance = new MonoSingleton();
            }
            return instance;
        }
        
    }*/

    private Singleton()
    {

    }
}
