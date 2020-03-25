using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;// assigns player speed
    public float rotSpeed;// how fast player rotates
    public Transform Body; // location data of player
    
    void Start()
    {
        
    }

    
    void Update()
    {

        Body.position += transform.forward * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.A))
        {
            Body.transform.Rotate(0, -rotSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Body.transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
        }
    }
}
