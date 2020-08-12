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
            this.rotSpeed = 100;
        }

    // Rotate the roulette based on the rotation speed
    transform.Rotate(0, 0, this.rotSpeed);

    // Decrease the speed of the roulette
    this.rotSpeed *= 0.96f;

    }
}
