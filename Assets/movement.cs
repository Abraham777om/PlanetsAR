using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    float x, y, z;
    float t = 0;
    public float a, b;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 2;
        z = 0;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        x = a * Mathf.Cos(t);
        y = 0;
        z = b * Mathf.Sin(t);
        transform.position = new Vector3(x, y, z);

        transform.Rotate(new Vector3(0, Time.deltaTime * 120, 0));

    }
}