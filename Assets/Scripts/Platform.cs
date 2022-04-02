using System.Collections;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 200;
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
