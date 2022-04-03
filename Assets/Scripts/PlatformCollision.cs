using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    public GameObject stopIt;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        stopIt.transform.position = new Vector3(0, 0, 0);
        Destroy(gameObject);
    }
}
