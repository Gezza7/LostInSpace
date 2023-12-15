using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if((collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Asteroid") && (!gameObject.GetComponent<Invincible>().getInvincible()))
        {
            if(collision.gameObject.tag == "EnemyBullet")
            {
                gameObject.GetComponent<Health>().takeDamage(collision.gameObject.GetComponent<EnemyBulletController>().getDamage());
            }
            else
            {
                Destroy(gameObject);
            }
            if (collision.gameObject.tag == "RepairKit") 
            { 
                gameObject.GetComponent<Health>().setHealth(100); 
            }

            Destroy(collision.gameObject);

        }
    }
    
   
}
