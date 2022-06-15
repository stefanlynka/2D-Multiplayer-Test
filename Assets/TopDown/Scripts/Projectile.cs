using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D MyRigidbody2D;
    public GameObject MySpriteHolder;

    public float cooldown = 1.0f;
    public int damage = 1;
    public float speed = 1.0f;
    public float duration = 3.0f;

    protected Vector2 angleVector;
    GameObject ownerGameObject;


    protected virtual void Update()
    {
        duration -= Time.deltaTime;
        if (duration <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collision(collision);
    }




    public virtual void Fire(GameObject owner, Vector2 angle)
    {
        angleVector = angle;
        ownerGameObject = owner;
        transform.position = owner.transform.position;
        Vector2 characterPosition = new Vector2(MySpriteHolder.transform.position.x, MySpriteHolder.transform.position.y);
        MySpriteHolder.transform.rotation = Quaternion.Euler(0, 0, Math2D.GetAngleBetweenPositions(characterPosition, Math2D.GetMousePosition()));
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ownerGameObject.GetComponent<Collider2D>());
    }
    protected virtual void Collision(Collision2D collision)
    {
    }
}
