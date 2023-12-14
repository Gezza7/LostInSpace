using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float ScrollSpeed = 1.0f; //Public float which allows for a base scroll speed which can be changed throughout gameplay. Each background Object can have their own amount of multiplier of this float for speed.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * ScrollSpeed *  Time.deltaTime); //Makes the background images scroll downwards with the value of the ScrollSpeed float.
        //Time.deltaTime calculates how many seconds have passed since the last frame. putting it in place allows for the scroll speed to stay the same on every device, even with differing framerates.
        if (transform.position.y < -60) //Detects if the Y value on the Object's position is under -60, if it is executes below.
        {
            transform.position = new Vector3(0, 55, 0); //Moves the Object back to the top of the screen once it has passed -60.
        }
    }
}
