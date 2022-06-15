using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public ProjectileLauncher MyProjectileLauncher;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 launchAngle = Math2D.NormalizeVectorBetweenPositions(new Vector2(transform.position.x, transform.position.y), Math2D.GetMousePosition());
            MyProjectileLauncher.TryLaunch(gameObject, launchAngle);
        }
    }
}
