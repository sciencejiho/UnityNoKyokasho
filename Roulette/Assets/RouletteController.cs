using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Rotation speed of the roulette
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        // Receive mouse click to manage the rotation speed
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

    // Rotate the roulette based on the rotation speed
    transform.Rotate(0, 0, this.rotSpeed);
    }
}
