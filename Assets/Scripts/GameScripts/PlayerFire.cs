using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab = null;

    [SerializeField] private float fireDelayTime = 2.5f;

    private float fireCounter = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && fireCounter <= 0.0f)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);

            fireCounter = fireDelayTime;
        }
        else
        {
            fireCounter -= Time.deltaTime;
        }

    }
}
