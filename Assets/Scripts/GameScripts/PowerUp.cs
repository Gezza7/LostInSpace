using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private GameObject kit = null;
    public float PUSpeed = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * PUSpeed * Time.deltaTime); //Allows for the GameObject to fall down the screen at a set speed
        if (transform.position.y < -20) //Detects the position of the GameObject and executes code if the Y position is below -20
        {
            Destroy(this.gameObject); //Destroys the GameObject
        }
        
    }
}
