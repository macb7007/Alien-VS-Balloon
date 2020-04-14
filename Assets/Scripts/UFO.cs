using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public float moveSpeed = 20f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.up * Time.fixedDeltaTime * Input.GetAxisRaw("Vertical") * moveSpeed);
        if (transform.position.y >= 4.67)
        {
            transform.position = new Vector3(transform.position.x, 4.66f, transform.position.z);
        }
        else if (transform.position.y <= -3.18)
        {
            transform.position = new Vector3(transform.position.x, -3.17f, transform.position.z);
        }
    }
}
