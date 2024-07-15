using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float timer;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if(timer >= 15)
        {
            gameObject.transform.position = new Vector3(Random.Range(-5, 5), 0.7f, Random.Range(-5, 5));





            timer = 0;
        }
    }
}
