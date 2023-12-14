using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private float fireDelay = 0.0f;
    private float counter = 5.0f;
    [SerializeField] private int score = 50;
    System.Random random;
    


    // Start is called before the first frame update
    void Start()
    {
        random = new System.Random(gameObject.GetInstanceID());
        counter = (fireDelay * ((random.Next(400) + 100) / 100)) + 2;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if(counter <= 0.0f)
        {
            enemyFire();
            counter = ((random.Next(4000) +1000) /1000);
        }
        
    }

    void enemyFire()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
    }
    public int getScore()
    {
        return score;
    }
}
