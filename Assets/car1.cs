using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public float moveSpeed = 5.0f; // Adjust the speed as needed
    public bool isUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // set the car to move down when the w key is pressed and up if w is pressed again
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isUp)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 25, transform.position.z);
                isUp = false;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 25, transform.position.z);
                isUp = true;
            }
        }
        
        //when left click is press instantiate a bullet at the car's position
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
        
        

    }
}
