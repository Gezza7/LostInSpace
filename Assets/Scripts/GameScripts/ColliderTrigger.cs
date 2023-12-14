using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Invader Hit!!!"); //1st attempt
        if (collision.gameObject.tag == "PlayerBullet")
        {
            //Debug.Log("Invader Hit by" + collision.gameObject.tag + " !!!");//2nd attempt
            //Destroy(gameObject);//3rd attempt
            gameObject.GetComponent<Health>().takeDamage(collision.gameObject.GetComponent<BulletController>().getDamage());

            Destroy(collision.gameObject); //3rd attempt
        }
    }

}
