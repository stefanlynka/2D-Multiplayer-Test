using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float cooldown = 0.0f;

    public void TryLaunch(GameObject owner, Vector2 angle)
    {
        if (projectilePrefab != null && cooldown <= 0.0f)
        {
            GameObject projectileObject = Instantiate(projectilePrefab);
            Projectile projectile = projectileObject.GetComponent<Projectile>();
            if (projectile != null)
            {
                projectile.Fire(owner, angle);
                cooldown = projectile.cooldown;
            }
        }
    }

    private void Update()
    {
        cooldown -= Time.deltaTime;
    }
}
