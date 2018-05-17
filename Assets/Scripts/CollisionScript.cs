﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {

        // Destroy everything that leaves the trigger
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);

        }
    

    }
}
