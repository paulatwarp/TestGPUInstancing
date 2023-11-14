using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatter : MonoBehaviour
{
    public Transform greenDot;
    public Transform redDot;
    public float radius;

    void Start()
    {
        for (int i = 0; i < 100; ++i)
        {
            Instantiate(greenDot, Random.insideUnitSphere * radius, Quaternion.identity);
            Instantiate(redDot, Random.insideUnitSphere * radius, Quaternion.identity);
        }
    }
}
