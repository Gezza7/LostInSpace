using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] private float speed = 5.0f;

    [SerializeField] private float damage = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = speed * Time.deltaTime;

        transform.Translate(new Vector3(0.0f, moveY, 0.0f), Space.World);
    }

    public float getDamage()
    {
        return damage;
    }
}
