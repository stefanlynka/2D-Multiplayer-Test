using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDown 
{
    public class CharacterMovement : MonoBehaviour {
        public Rigidbody2D MyRigidbody2D;
        public SpriteRenderer MySpriteRenderer;
        public float Speed = 100.0f;
        private float BaseSpeed = 1000f;


        Vector2 mouseWorldPosition = new Vector2();

        // Start is called before the first frame update
        void Start()
        {
            Application.targetFrameRate = 60;
        }

        // Update is called once per frame
        void Update()
        {
            mouseWorldPosition = Math2D.GetMousePosition();
            UpdatePosition();
            UpdateRotation();
        }
        private void UpdatePosition()
        {
            Vector2 moveVector = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                moveVector.x += -1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveVector.x += 1;
            }

            if (Input.GetKey(KeyCode.W))
            {
                moveVector.y += 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveVector.y += -1;
            }

            moveVector.Normalize();
            MyRigidbody2D.velocity = (Speed * BaseSpeed * Time.deltaTime) * moveVector;
        }
        private void UpdateRotation()
        {
            Vector2 characterPosition = new Vector2(transform.position.x, transform.position.y);
            MySpriteRenderer.transform.rotation = Quaternion.Euler(0, 0, Math2D.GetAngleBetweenPositions(characterPosition, mouseWorldPosition));
        }
    }
}

