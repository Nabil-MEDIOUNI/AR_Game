using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_anim : MonoBehaviour
{
    public float rot=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rot*1000f * Time.deltaTime);
    }
}
