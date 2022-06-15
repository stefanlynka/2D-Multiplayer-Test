using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLaser : Projectile 
{
    public override void Fire(GameObject owner, Vector2 angle)
    {
        base.Fire(owner, angle);
        Debug.LogError("Fired Laser");
    }
    protected override void Collision(Collision2D collision)
    {
        base.Collision(collision);

        Unit target = collision.gameObject.GetComponentInParent<Unit>();
        if (target != null && (target.UnitType == UnitType.Enemy || target.UnitType == UnitType.Object))
        {
            target.TakeDamage(damage);
            Debug.LogError("Take " + damage + " Damage From Laser");
            Destroy(gameObject);
        }
    }
    protected override void Update()
    {
        MyRigidbody2D.velocity = speed * angleVector;
        base.Update();
    }
}
