using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
// set the bullet to move when created and destroy it after 2 seconds
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(100, 0);
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
