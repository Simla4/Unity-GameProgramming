using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    /*
     We have a spaceship that can fire. This spaceship has 3 different type firing.
     We cannot create if else for each firing type in the same script because other types of firing can be added to the game.
     This situation impairs the readability of the code.
     */

    private ILauncher launcher;

    [SerializeField] private float fireRefreshTime = 1f;

    private float nextFireTime;

    void Awake()
    {
        launcher = GetComponent<ILauncher>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {

        }
    }

    private bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    private void FireWeapon()
    {
        nextFireTime = Time.time + fireRefreshTime;
        launcher.Launch(this);
    }
}
