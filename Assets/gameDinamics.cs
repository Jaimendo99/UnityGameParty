using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameDinamics : MonoBehaviour
{
    GameObject Car;

    private GameObject bad;

    private GameObject dog;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create a bad prefab every 5 seconds radomly ether y = 0 or y = 25
        if (Time.frameCount % 300 == 0)
        {
            bad = Instantiate(bad, new Vector3(100, Random.Range(0, 2) * 25, 0), Quaternion.identity);
        }
    }
}
