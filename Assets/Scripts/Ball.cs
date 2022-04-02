using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 150.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    float collisionChange(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "platform")
        {
            float x = collisionChange(transform.position,
                              col.transform.position,
                              col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
