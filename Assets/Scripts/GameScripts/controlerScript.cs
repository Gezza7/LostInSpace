using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerScript : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float leftRightInput = Input.GetAxis("Horizontal");
        float upDownInput = Input.GetAxis("Vertical");

        float yStop = 1;
        float xStop = 1;
        
        if (gameObject.transform.position.x > 9 && leftRightInput > 0) 
        { 
            xStop = 0;
        }
         if(gameObject.transform.position.x < -9 && leftRightInput < 0)
        {
            xStop = 0;
        }
         if(gameObject.transform.position.y > 4.1 && upDownInput > 0)
        {
            yStop = 0;
        }
         if(gameObject.transform.position.y < -4.1 && upDownInput < 0)
        {
            yStop = 0;
        }
        
        Vector2 horizontalMoveVector = Vector2.right * leftRightInput * xStop;
        Vector2 verticalMoveVector = Vector2.up * upDownInput * yStop;

        Vector2 moveVector = (horizontalMoveVector + verticalMoveVector) * speed * Time.deltaTime;

        transform.Translate(moveVector);
        
    }
}
