using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Generate : MonoBehaviour
{
    public GameObject[] figures;

    public void generate()
    {
        Random r = new Random();
        int x = r.Next(0, 8);
        Instantiate(figures[0],
                    new Vector3(-10+x*20, 80, 0),
                    Quaternion.identity);
    }

    void Start()
    {
        generate();
    }
}
