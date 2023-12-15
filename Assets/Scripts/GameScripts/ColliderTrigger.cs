using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "PlayerBullet")
        {
            
            gameObject.GetComponent<Health>().takeDamage(collision.gameObject.GetComponent<BulletController>().getDamage());

            Destroy(collision.gameObject); 
        }
    }

}
