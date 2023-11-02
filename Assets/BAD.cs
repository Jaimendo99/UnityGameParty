using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move object to the left with a speed of 5
        transform.position = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
        
    }
}
