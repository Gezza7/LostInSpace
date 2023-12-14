using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y > 20 || gameObject.transform.position.y < -12)
        {
            Destroy(gameObject);
        }

        if(gameObject.transform.position.x > 12 || gameObject.transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
