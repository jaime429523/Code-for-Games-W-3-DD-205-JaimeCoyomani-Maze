using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += 0.5f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            newPos.x += -0.5f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            newPos.z += 0.5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            newPos.z += -0.5f;
        }

        transform.position = newPos;
        
    }
}
