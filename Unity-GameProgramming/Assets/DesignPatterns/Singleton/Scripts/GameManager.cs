using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public void Write()
    {
        Debug.Log("Mono singleton working...");
    }
}
