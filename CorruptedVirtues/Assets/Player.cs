using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool verticalInputInUse = false, horizontalInputInUse = false;
    void Update()
    {
        int horizontalInput = (int)Input.GetAxisRaw("Horizontal");
        int verticalInput = (int)Input.GetAxisRaw("Vertical");
        if (verticalInput == 0)
        {
            verticalInputInUse = false;
        }
        if (horizontalInput == 0)
        {
            horizontalInputInUse = false;
        }

        if (verticalInput != 0 && !verticalInputInUse)
        {
            verticalInputInUse = true;
            if (verticalInput > 0)
            {
                transform.Translate(0, 1, 0);   
            }
            else
            {
                transform.Translate(0, -1, 0);
            }
        }
        if (horizontalInput != 0 && !horizontalInputInUse)
        {
            horizontalInputInUse = true;
            if (horizontalInput > 0)
            {
                transform.Translate(1, 0, 0);
            }
            else
            {
                transform.Translate(-1, 0, 0);
            }
        }
    }
}
