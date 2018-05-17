using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {

        // Destroy everything that leaves the trigger
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);

        }
    }
}
