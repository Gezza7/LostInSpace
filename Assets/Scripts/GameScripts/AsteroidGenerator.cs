using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] asteroidTypes = new GameObject[4] { null, null, null, null };

    [SerializeField] private float asteroidSpawnTime = 1.0f;
    [SerializeField] private float horizontalSpeed = 1.0f;
    [SerializeField] private float verticalSpeed = 0.5f;
    [SerializeField] private float rotationSpeed = 1.0f;
    private float countdown = 20.0f;

    System.Random rndGen;

    // Start is called before the first frame update
    void Start()
    {
        rndGen = new System.Random();
    }


    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f)
        {
            generateAsteroid();
            countdown = asteroidSpawnTime;
        }
    }

    void generateAsteroid()
    {
        int typeIndex = rndGen.Next(4);
        int side = rndGen.Next(2);
        float leftRight;
        if(side == 1)
        {
            leftRight = -10.0f;
        }
        else
        {
            leftRight = 10.0f;
        }
        GameObject asteroid = Instantiate(asteroidTypes[typeIndex], new Vector2(leftRight, (float)(rndGen.Next(10) + 5)), Quaternion.identity);
        //make generate asteroid at random place above game scene
        if(side == 1)
        {
            asteroid.GetComponent<AsteroidController>().setLeftSpeed(-1 * horizontalSpeed * ((rndGen.Next(40) +10) /10) +1);
        }
        else
        {
            asteroid.GetComponent<AsteroidController>().setLeftSpeed(horizontalSpeed *rndGen.Next(5));
        }
        asteroid.GetComponent<AsteroidController>().setVerticalSpeed(verticalSpeed * ((rndGen.Next(40) + 10) / 10));
        asteroid.GetComponent<AsteroidController>().setRotation(rotationSpeed * (rndGen.Next(50) - 20));

    }
}

