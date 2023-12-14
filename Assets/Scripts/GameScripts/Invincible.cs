using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{

    private bool isInvincible = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setInvincible(bool state)
    {
        isInvincible = state;
    }

    public bool getInvincible()
    {
        return isInvincible;
    }
}
