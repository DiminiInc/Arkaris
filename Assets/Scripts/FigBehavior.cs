using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigBehavior : MonoBehaviour
{
    public float step;
    public int iterCounter;
    // Start is called before the first frame update
    void Start()
    {
        step = Time.time;
        iterCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - step >= 1 && iterCounter<8)
        {
            transform.position += new Vector3(0, -20, 0);
            iterCounter += 1;
            step = Time.time;
        }
    }
}
