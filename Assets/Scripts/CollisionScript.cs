using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {

        // Destroy everything that leaves the trigger
        if (other.gameObject.tag == "Cube")
        {
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(this.gameObject);

        }

    }
}
