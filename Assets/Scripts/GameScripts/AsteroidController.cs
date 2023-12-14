using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{


    [SerializeField] private float leftSpeed = 1.0f;
    [SerializeField] private float downSpeed = 1.0f;
    [SerializeField] private float rotationSpeed = 1.0f;
    [SerializeField] private int score = 50;
    System.Random randomGen;
    // Start is called before the first frame update
    void Start()
    {
        //randomGen = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector2.left * leftSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector2.down * downSpeed * Time.deltaTime, Space.World);
        //make asteroid random speed and rotation

    }

    public void setLeftSpeed(float speed)
    {
        leftSpeed = speed;
    }

    public void setVerticalSpeed(float speed)
    {
        downSpeed = speed;
    }

    public void setRotation(float rotation)
    {
        rotationSpeed = rotation;
    }
    public int getScore()
    {
        return score;
    }

}
