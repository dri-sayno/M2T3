using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchpad : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Rocket Ship")
        {
            Renderer rend = GetComponent<Renderer>();
            Color color = Color.green;

            rend.material.color = color;
        }
    }
}
