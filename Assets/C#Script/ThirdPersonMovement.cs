using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        
        transform.Rotate(0f, horizontal, 0f);

       
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        if (direction.magnitude >= 0.1f)
        {
            
            if (vertical > -0.1f)
            {
                transform.position += transform.forward * speed;
            }
            else
            {
                transform.position -= transform.forward * speed;
            }
        }

    }

}
