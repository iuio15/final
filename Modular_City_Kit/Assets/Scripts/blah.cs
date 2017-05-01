using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blah : MonoBehaviour {

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
