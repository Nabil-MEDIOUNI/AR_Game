using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float speed = 0f;
    public float min = 2f;
    public float max = 5f;
    void Start()
    {
        speed = Random.Range(min, max);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(Camera.main.transform);
    }
}
