using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float health = 100.0f;
    private GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            
            if(gameObject.tag == "Asteroid")
            {
                GameObject.Find("GameLoop").GetComponent<Score>().updateScore(gameObject.GetComponent<AsteroidController>().getScore());
                
            }
            else if(gameObject.tag == "Enemy")
            {
               
                GameObject.Find("GameLoop").GetComponent<Score>().updateScore(gameObject.GetComponent<EnemyFire>().getScore());
            }
            
            death();
        }
    }
    void death()
    {
        Destroy(gameObject);
    }
    public void takeDamage(float damage)
    {
        health -= damage;
    }
}
